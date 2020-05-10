using ImageEditor.ImageEffects;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ImageEditor
{
    /// <summary>
    /// Main GUI
    /// </summary>
    public partial class MainForm : Form
    {
        private HistoryManager _historyManager;
        private string _path = string.Empty;
        private string _loadedPath = string.Empty;
        private IconButton _currentButton;
        private Panel _leftBorderBtn;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        private struct ButtonColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 155);
            public static Color color7 = Color.FromArgb(53, 177, 211);
        }

        /// <summary>
        /// Creates and sets variables
        /// </summary>
        private void InitializeGui()
        {
            _historyManager = new HistoryManager();
            pictureBox.AllowDrop = true;
            SetButtonState( false );
            _leftBorderBtn = new Panel();
            _leftBorderBtn.Size = new Size( 7, 60 );
            panelEffects.Controls.Add( _leftBorderBtn );
        }

        /// <summary>
        /// Visually highlights a button
        /// </summary>
        private void HightlightButton(object sender, Color color)
        {
            if(sender != null)
            {
                DisableHighlight();

                _currentButton = sender as IconButton;
                _currentButton.BackColor = Color.FromArgb( 37, 36, 81 );
                _currentButton.ForeColor = color;
                _currentButton.TextAlign = ContentAlignment.MiddleCenter;
                _currentButton.IconColor = color;
                _currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                _currentButton.ImageAlign = ContentAlignment.MiddleRight;

                _leftBorderBtn.BackColor = color;
                _leftBorderBtn.Location = new Point( 0, _currentButton.Location.Y );
                _leftBorderBtn.Visible = true;
                _leftBorderBtn.BringToFront();
            }
        }

        /// <summary>
        /// Disables hightlight for a button by reverting back to default settings
        /// </summary>
        private void DisableHighlight()
        {
            if(_currentButton != null)
            {
                _currentButton.BackColor = Color.FromArgb( 31, 30, 68 );
                _currentButton.ForeColor = Color.Gainsboro;
                _currentButton.TextAlign = ContentAlignment.MiddleLeft;
                _currentButton.IconColor = Color.Gainsboro;
                _currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                _currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        /// <summary>
        /// Enables or disables buttons on the form
        /// </summary>
        /// <param name="active">true if enabled, false if disabled</param>
        private void SetButtonState(bool active)
        {
            icnBtnGrayscale.Enabled = 
                icnBtnSepia.Enabled = 
                icnBtnInverse.Enabled = 
                icnBtnCircle.Enabled =
                icnBtnTint.Enabled =
                icnBtnBrightness.Enabled =
                icnBtnContrast.Enabled =
                btnSave.Enabled =
                active;
        }

        /// <summary>
        /// Gets filename
        /// </summary>
        /// <param name="fileNames">array of filenames</param>
        /// <returns>filename if valid else empty string</returns>
        private string GetFileName(string[] fileNames)
        {
            if( fileNames != null && fileNames.Length >= 1 )
                return ValidateExt(fileNames[0]) ? fileNames[0] : string.Empty;

            return string.Empty;
        }

        /// <summary>
        /// Checks if extension of filename is allowed
        /// </summary>
        /// <param name="fileName">the filename</param>
        /// <returns>true if valid else false</returns>
        private bool ValidateExt(string fileName)
        {
            string ext = Path.GetExtension(fileName).ToLower();
            return ( ( ext == ".jpg" ) || ( ext == ".png" ) || ( ext == ".bmp" ) );
        }

        /// <summary>
        /// Updates the GUI
        /// </summary>
        private void UpdateGui()
        {
            // Display * next to title if the file hasn't been saved
            if(_historyManager.GetCurrent().IsSaved)
            {
                Text = Text.Replace( "*", "" );
            }
            else
            {
                if( !Text.Contains( "*" ) )
                    Text += "*";
            }
        }

        /// <summary>
        /// Loads an image from a filename
        /// </summary>
        /// <param name="fileName">filename of the image to load</param>
        private void LoadImage(string fileName)
        {
            if( !string.IsNullOrWhiteSpace( fileName ) )
            {
                _loadedPath = fileName;

                using( var tempImg = new Bitmap( fileName ) )
                    pictureBox.Image = new Bitmap( tempImg );

                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                _historyManager.Append( new HistoryImage( pictureBox.Image as Bitmap ) );
                SetButtonState( true );
                UpdateGui();
            }
        }

        /// <summary>
        /// Event handler for drag/drop event on the PictureBox
        /// Loads the dropped image
        /// </summary>
        private void pictureBox_DragDrop( object sender, DragEventArgs e )
        {
            string fileName = GetFileName(e.Data.GetData(DataFormats.FileDrop) as string[]);
            LoadImage( fileName );
        }

        /// <summary>
        /// Event handler for drag enter on the Picture box
        /// Sets dragdropeffect depending on type of file
        /// </summary>
        private void pictureBox_DragEnter( object sender, DragEventArgs e )
        {
            string fileName = GetFileName(e.Data.GetData(DataFormats.FileDrop) as string[]);

            if( !string.IsNullOrWhiteSpace( fileName ) )
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Opens GrayscaleForm
        /// </summary>
        private void icnBtnGrayscale_Click( object sender, System.EventArgs e )
        {
            HightlightButton( sender, ButtonColors.color1 );
            ShowEffectForm( new GrayscaleForm( _historyManager.GetCurrent(), _historyManager.GetHistory(), _historyManager.CurrIndex ) );
        }

        /// <summary>
        /// Opens SepiaForm
        /// </summary>
        private void icnBtnSepia_Click( object sender, System.EventArgs e )
        {
            HightlightButton( sender, ButtonColors.color6 );
            ShowEffectForm( new SepiaForm( _historyManager.GetCurrent(), _historyManager.GetHistory(), _historyManager.CurrIndex ) );
        }

        /// <summary>
        /// Inverse the colors of the image
        /// </summary>
        private void icnBtnInverse_Click( object sender, System.EventArgs e )
        {
            HightlightButton( sender, ButtonColors.color5 );
            ApplyEffect( new InverseEffect() );
        }

        /// <summary>
        /// Creates a circular frame for the image
        /// </summary>
        private void icnBtnCircle_Click( object sender, System.EventArgs e )
        {
            HightlightButton( sender, ButtonColors.color4 );
            ApplyEffect( new CircleEffect() );
        }

        /// <summary>
        /// Opens TintForm
        /// </summary>
        private void icnBtnTint_Click( object sender, System.EventArgs e )
        {
            HightlightButton( sender, ButtonColors.color3 );
            ShowEffectForm( new TintForm( _historyManager.GetCurrent(), _historyManager.GetHistory(), _historyManager.CurrIndex ) );
        }

        /// <summary>
        /// Opens BrightnessForm
        /// </summary>
        private void icnBtnBrightness_Click( object sender, System.EventArgs e )
        {
            ShowEffectForm( new BrightnessForm( _historyManager.GetCurrent(), _historyManager.GetHistory(), _historyManager.CurrIndex ) );
            HightlightButton( sender, ButtonColors.color2 );
        }

        /// <summary>
        /// Opens ContrastForm
        /// </summary>
        private void icnBtnContrast_Click( object sender, System.EventArgs e )
        {
            HightlightButton( sender, ButtonColors.color7 );
            ShowEffectForm( new ContrastForm( _historyManager.GetCurrent(), _historyManager.GetHistory(), _historyManager.CurrIndex ) );
        }

        /// <summary>
        /// Opens an effect form
        /// Checks if the effect was applied
        /// </summary>
        /// <param name="form">The form to open</param>
        private void ShowEffectForm(EffectFormBase form)
        {
            if( form.ShowDialog() == DialogResult.OK )
            {
                _historyManager.Append( form.Img );
                pictureBox.Image = form.Img.Image;
                UpdateGui();
            }
        }

        /// <summary>
        /// Applies an effect to the image
        /// </summary>
        /// <param name="effect">The effect to apply</param>
        private void ApplyEffect(IImageEffect effect)
        {
            Image img = pictureBox.Image;
            if( img != null )
            {
                Bitmap grayImg = effect.ApplyEffect(img as Bitmap);

                pictureBox.Image = grayImg;
                _historyManager.Append( new HistoryImage(grayImg, effect) );
            }
        }

        /// <summary>
        /// Opens an image using filedialog
        /// </summary>
        private void loadToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            OpenImg();
        }

        /// <summary>
        /// Saves the image
        /// </summary>
        private void saveToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            SaveImg();
        }

        /// <summary>
        /// Revert most recent change
        /// </summary>
        private void revertToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            pictureBox.Image = _historyManager.Revert().Image;
            UpdateGui();
        }

        /// <summary>
        /// Redo most recent reverted change
        /// </summary>
        private void redoToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            pictureBox.Image = _historyManager.Redo().Image;
            UpdateGui();
        }

        /// <summary>
        /// Exits the app
        /// </summary>
        private void exitToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            Application.Exit();
        }

        /// <summary>
        /// Saves the image
        /// </summary>
        private void btnSave_Click( object sender, System.EventArgs e )
        {
            SaveImg();
        }

        /// <summary>
        /// Loads image using filedialog
        /// </summary>
        private void btnLoad_Click( object sender, System.EventArgs e )
        {
            OpenImg();
        }

        /// <summary>
        /// Saves image using filedialog if no path has previously been set
        /// If there's already a path set, the image is saved to that path
        /// </summary>
        private void SaveImg()
        {
            if(string.IsNullOrWhiteSpace(_path))
            {
                SaveImgAs();
                return;
            }

            if( _historyManager.GetIsSaved() )
                return;

            pictureBox.Image.Save( _path );
            _historyManager.Save();
            UpdateGui();
        }

        /// <summary>
        /// Saves the image using a filedialog
        /// </summary>
        private void SaveImgAs()
        {
            if( _historyManager.CurrIndex < 0 )
                return;

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Images|*.png;*.bmp;*.jpg";
            saveDialog.Title = "Save image as...";
            ImageFormat format = ImageFormat.Png;
            if( saveDialog.ShowDialog() == DialogResult.OK )
            {
                string ext = Path.GetExtension(saveDialog.FileName);
                switch( ext )
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                _path = saveDialog.FileName;
                SaveImg();
            }
        }

        /// <summary>
        /// Opens an image using filedialog
        /// </summary>
        private void OpenImg()
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Images|*.png;*.bmp;*.jpg";
            openDialog.Title = "Open image";

            if( openDialog.ShowDialog() == DialogResult.OK )
                LoadImage( openDialog.FileName );
        }

        /// <summary>
        /// Saves image using filedialog
        /// </summary>
        private void saveAsToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            SaveImgAs();
        }

        /// <summary>
        /// Promps user to save
        /// </summary>
        private void PromptForSave()
        {
            const string msg = "Would you like to save before exiting?";
            const string caption = "You have unsaved work";

            if(MessageBox.Show( msg, caption, MessageBoxButtons.YesNo ) == DialogResult.Yes )
                SaveImg();
        }

        /// <summary>
        /// If there's unsaved changes, the user is prompted to save before the app is closed
        /// </summary>
        private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
        {
            if(!_historyManager.GetIsSaved())
                PromptForSave();
        }
    }
}
