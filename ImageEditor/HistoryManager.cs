using System.Collections.Generic;

namespace ImageEditor
{
    class HistoryManager
    {
        private List<HistoryImage> _imageHistory;
        public int CurrIndex { get; private set; } = -1;
        private const int MaxHisotryRecords = 50;

        public HistoryManager()
        {
            _imageHistory = new List<HistoryImage>();
        }

        public HistoryImage Revert()
        {
            if( _imageHistory.Count == 0 )
                return null;

            if( CurrIndex > 0 )
                return _imageHistory[--CurrIndex];

            // Clone so history can't be modified outside of class
            return (HistoryImage)_imageHistory[CurrIndex].Clone();
        }

        public void Save()
        {
            foreach( HistoryImage img in _imageHistory )
                img.IsSaved = false;

            _imageHistory[CurrIndex].IsSaved = true;
        }

        public List<HistoryImage> GetHistory()
        {
            // Return copy so the history can't be changed outside this class
            List<HistoryImage> historyCopy = new List<HistoryImage>();
            foreach( HistoryImage img in _imageHistory )
                historyCopy.Add( (HistoryImage)img.Clone() );

            return new List<HistoryImage>( _imageHistory );
        }

        public bool GetIsSaved()
        {
            if( _imageHistory.Count == 0 )
                return true;

            return _imageHistory[CurrIndex].IsSaved;
        }

        public HistoryImage Redo()
        {
            if( _imageHistory.Count == 0 )
                return null;

            if( ( _imageHistory.Count - 1 ) > CurrIndex )
                return _imageHistory[++CurrIndex];

            return (HistoryImage)_imageHistory[CurrIndex].Clone();
        }

        public HistoryImage GetCurrent()
        {
            return _imageHistory.Count != 0 ? (HistoryImage)_imageHistory[CurrIndex].Clone() : null;
        }

        public void Append(HistoryImage img)
        {
            // Remove history after current index in case user has reverted before
            for( int i = _imageHistory.Count - 1; i > CurrIndex; --i )
                _imageHistory.RemoveAt( i );

            _imageHistory.Add( img );
            ++CurrIndex;

            LimitHistory();
        }

        private void LimitHistory()
        {
            int diff = _imageHistory.Count - MaxHisotryRecords;
            if( diff > 0 )
            {
                CurrIndex -= diff;
                _imageHistory.RemoveRange( 0, diff );
            }
        }
    }
}
