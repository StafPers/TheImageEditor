using ImageEditor.ImageEffects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ImageEditor
{
    /// <summary>
    /// Class used for storing and handling the history of edits on images
    /// 
    /// </summary>
    public class HistoryManager
    {
        private List<HistoryImage> _imageHistory;
        private List<HistoryImage> _originalImages;
        public int CurrIndex { get; private set; } = -1;
        private const int MaxHisotryRecords = 20;

        /// <summary>
        /// Constructor
        /// </summary>
        public HistoryManager()
        {
            _imageHistory = new List<HistoryImage>();
            _originalImages = new List<HistoryImage>();
        }

        /// <summary>
        /// Revert (ctrl + z) Go back 1 strep in the hisotory
        /// </summary>
        /// <returns>The HistoryImage at the previous position</returns>
        public HistoryImage Revert()
        {
            if( _imageHistory.Count == 0 )
                return null;

            if( CurrIndex > 0 )
                return (HistoryImage)_imageHistory[--CurrIndex].Clone();

            // Clone so history can't be modified outside of class
            return (HistoryImage)_imageHistory[CurrIndex].Clone();
        }

        /// <summary>
        /// Checks if the effect has already been applied
        /// </summary>
        /// <returns>The image with the applied effect or null if effect has not been applied</returns>
        public HistoryImage HasEffect<T>()
        {
            int? id = GetCurrent()?.Id;

            if( id == null )
                return null;

            for(int i = CurrIndex; i >= 0; --i )
            {
                HistoryImage img = _imageHistory[i];

                if( img.Id != id )
                    return null;

                if( img.Effect != null && img.Effect is T )
                    return img;
            }

            return null;
        }

        /// <summary>
        /// Flags the the current image as saved
        /// Remove saved flag for all other history records
        /// </summary>
        public void Save()
        {
            foreach( HistoryImage img in _imageHistory )
                img.IsSaved = false;

            _imageHistory[CurrIndex].IsSaved = true;
        }

        /// <summary>
        /// Gets a copy of the history
        /// </summary>
        /// <returns>A copied list of the history</returns>
        public List<HistoryImage> GetHistory()
        {
            // Return copy so the actual history can't be changed outside this class
            List<HistoryImage> historyCopy = new List<HistoryImage>();
            foreach( HistoryImage img in _imageHistory )
                historyCopy.Add( (HistoryImage)img.Clone() );

            return new List<HistoryImage>( _imageHistory );
        }

        /// <summary>
        /// Checks if the current Image has been saved
        /// </summary>
        /// <returns>true if it's flagged as saved, else false</returns>
        public bool GetIsSaved()
        {
            if( _imageHistory.Count == 0 )
                return true;

            return _imageHistory[CurrIndex].IsSaved;
        }

        /// <summary>
        /// Redo(ctrl + y) Moves to the next step in the history in case reverts has been applied
        /// </summary>
        /// <returns>The image at the next step</returns>
        public HistoryImage Redo()
        {
            if( _imageHistory.Count == 0 )
                return null;

            if( ( _imageHistory.Count - 1 ) > CurrIndex )
                return _imageHistory[++CurrIndex];

            return (HistoryImage)_imageHistory[CurrIndex].Clone();
        }

        /// <summary>
        /// Gets a copy of the current Image
        /// </summary>
        /// <returns>A copy of the current image</returns>
        public HistoryImage GetCurrent()
        {
            return _imageHistory.Count != 0 ? (HistoryImage)_imageHistory[CurrIndex].Clone() : null;
        }

        /// <summary>
        /// Adds a new image to the history
        /// </summary>
        /// <param name="img">The image to be added</param>
        public void Append(HistoryImage img)
        {
            // Remove history after current index in case user has reverted before
            for( int i = _imageHistory.Count - 1; i > CurrIndex; --i )
                _imageHistory.RemoveAt( i );

            if( _originalImages.Find( x => x.Id == img.Id ) == null )
                _originalImages.Add( img );

            _imageHistory.Add( img );
            ++CurrIndex;

            LimitHistory();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        /// <summary>
        /// Limits the amount history records in order to not have the software
        /// Take an unnecessary amount of ram 
        /// </summary>
        private void LimitHistory()
        {
            int diff = _imageHistory.Count - MaxHisotryRecords;
            if( diff > 0 )
            {
                CurrIndex -= diff;
                _imageHistory.RemoveRange( 0, diff );
            }
        }

        /// <summary>
        /// Appends the original version of the current image to the history
        /// </summary>
        /// <returns>The original image</returns>
        public Bitmap ClearEffects()
        {
            int? id = GetCurrent()?.Id;

            if(id != null)
                return (Bitmap)_originalImages.Where( x => x.Id == id ).FirstOrDefault()?.Image.Clone();

            return null;
        }

        /// <summary>
        /// Gets an original image with no effects
        /// </summary>
        /// <param name="id">The id of the image to return</param>
        public HistoryImage GetOriginalImage(int id)
        {
            return (HistoryImage)_originalImages.Where( x => x.Id == id ).FirstOrDefault()?.Clone();
        }

        /// <summary>
        /// Returns a version of the current image without the effect of type T without storing it in the history
        /// </summary>
        public HistoryImage PreviewRemovedEffect<T>()
        {
            int id = _imageHistory[CurrIndex].Id;
            HistoryImage original = GetOriginalImage(id);

            if( original == null )
                return null;

            List<HistoryImage> effectsToApply = _imageHistory.Where(x => x.Id == id && x.Effect != null && !(x.Effect is T)).ToList();

            // I need to trim duplicates starting from the back in order for 
            // The effects to be applied correctly
            RemoveDuplicates( effectsToApply );

            foreach( HistoryImage img in effectsToApply )
            {
                Bitmap newImg = img.Effect?.ApplyEffect( original.Image );

                if( newImg != null )
                {
                    original.Effect = img.Effect;
                    original.Image = newImg;
                }
            }

            return original;
        }

        private void RemoveDuplicates(List<HistoryImage> images)
        {
            for( int i = images.Count - 1; i > 0; --i )
            {
                IImageEffect effect = images[i].Effect;

                for( int j = i - 1; j >= 0; --j )
                {
                    if( effect.GetType() == images[j].Effect.GetType() )
                    {
                        --i;
                        images.RemoveAt( j );
                    }
                }
            }
        }
    }
}
