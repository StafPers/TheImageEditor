using ImageEditor.ImageEffects;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System;

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
        private EffectFormBase _currEffectForm;
        private BrightnessForm _brightnessForm;
        private ContrastForm _contrashForm;
        private SepiaForm _sepiaForm;
        private GrayscaleForm _grayscaleForm;
        private TintForm _tintForm;

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
            //Remove default titlebar
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;

            _brightnessForm = new BrightnessForm();
            _contrashForm = new ContrastForm();
            _sepiaForm = new SepiaForm();
            _grayscaleForm = new GrayscaleForm();
            _tintForm = new TintForm();

            _brightnessForm.EffectApplied += OnEffectApplied;
            _brightnessForm.EffectCanceled += OnEffectCanceled;
            _contrashForm.EffectApplied += OnEffectApplied;
            _contrashForm.EffectCanceled += OnEffectCanceled;
            _sepiaForm.EffectApplied += OnEffectApplied;
            _sepiaForm.EffectCanceled += OnEffectCanceled;
            _grayscaleForm.EffectApplied += OnEffectApplied;
            _grayscaleForm.EffectCanceled += OnEffectCanceled;
            _tintForm.EffectApplied += OnEffectApplied;
            _tintForm.EffectCanceled += OnEffectCanceled;

            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            _historyManager = new HistoryManager();
            pictureBox.AllowDrop = true;
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
        /// Callback for when an effect is canceled, resets the form
        /// </summary>
        public void OnEffectCanceled( object src, EventArgs e )
        {
            Reset();
        }

        /// <summary>
        /// Callback for when an effect is applied, resets the form
        /// </summary>
        public void OnEffectApplied( object src, EventArgs e )
        {
            if(_currEffectForm != null)
            {
                _historyManager.Append( _currEffectForm.Img );
                pictureBox.Image = _currEffectForm.Img.Image;
                UpdateGui();
                DisableHighlight();
                Reset();
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
                _leftBorderBtn.Visible = false;
            }
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
                lblTitle.Text = lblTitle.Text.Replace( "*", "" );
            }
            else
            {
                if( !lblTitle.Text.Contains( "*" ) )
                    lblTitle.Text += "*";
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
            if( _historyManager.GetCurrent() == null )
                return;

            HightlightButton( sender, ButtonColors.color1 );
            ShowEffectForm( _grayscaleForm );
        }

        /// <summary>
        /// Opens SepiaForm
        /// </summary>
        private void icnBtnSepia_Click( object sender, System.EventArgs e )
        {
            if( _historyManager.GetCurrent() == null )
                return;

            HightlightButton( sender, ButtonColors.color6 );
            ShowEffectForm( _sepiaForm );
        }

        /// <summary>
        /// Inverse the colors of the image
        /// </summary>
        private void icnBtnInverse_Click( object sender, System.EventArgs e )
        {
            if( _historyManager.GetCurrent() == null || _currEffectForm != null )
                return;

            HightlightButton( sender, ButtonColors.color5 );
            ApplyEffect( new InverseEffect() );
        }

        /// <summary>
        /// Creates a circular frame for the image
        /// </summary>
        private void icnBtnCircle_Click( object sender, System.EventArgs e )
        {
            if( _historyManager.GetCurrent() == null || _currEffectForm != null )
                return;

            HightlightButton( sender, ButtonColors.color4 );
            ApplyEffect( new CircleEffect() );
        }

        /// <summary>
        /// Opens TintForm
        /// </summary>
        private void icnBtnTint_Click( object sender, System.EventArgs e )
        {
            if( _historyManager.GetCurrent() == null )
                return;

            HightlightButton( sender, ButtonColors.color3 );
            ShowEffectForm( _tintForm );
        }

        /// <summary>
        /// Opens BrightnessForm
        /// </summary>
        private void icnBtnBrightness_Click( object sender, System.EventArgs e )
        {
            if( _historyManager.GetCurrent() == null )
                return;

            ShowEffectForm( _brightnessForm );
            HightlightButton( sender, ButtonColors.color2 );
        }

        /// <summary>
        /// Opens ContrastForm
        /// </summary>
        private void icnBtnContrast_Click( object sender, System.EventArgs e )
        {
            if( _historyManager.GetCurrent() == null )
                return;

            HightlightButton( sender, ButtonColors.color7 );
            ShowEffectForm( _contrashForm );
        }

        /// <summary>
        /// Opens an effect form
        /// Checks if the effect was applied
        /// </summary>
        /// <param name="form">The form to open</param>
        private void ShowEffectForm(EffectFormBase form)
        {
            _currEffectForm = form;

            _currEffectForm.TopLevel = false;
            _currEffectForm.FormBorderStyle = FormBorderStyle.None;
            _currEffectForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add( _currEffectForm );
            panelDesktop.Tag = _currEffectForm;
            _currEffectForm.BringToFront();

            _currEffectForm.ShowForm( _historyManager.GetCurrent(), _historyManager.GetHistory(), _historyManager.CurrIndex );
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
        /// Saves the image
        /// </summary>
        private void icnBtnSave_Click( object sender, System.EventArgs e )
        {
            if( _historyManager.GetCurrent() == null )
                return;

            SaveImg();
        }

        /// <summary>
        /// Loads image using filedialog
        /// </summary>
        private void icnBtnLoad_Click( object sender, System.EventArgs e )
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

        private void pictureBoxLogo_Click( object sender, System.EventArgs e )
        {
            Reset();
        }

        private void Reset()
        {
            DisableHighlight();

            if(_currEffectForm != null)
            {
                _currEffectForm.Hide();
                _currEffectForm = null;
            }
        }

        /// <summary>
        /// Opens an image using filedialog
        /// </summary>
        private void loadMenuItem_Click( object sender, System.EventArgs e )
        {
            OpenImg();
        }

        /// <summary>
        /// Saves the image
        /// </summary>
        private void saveMenuItem_Click( object sender, System.EventArgs e )
        {
            SaveImg();
        }

        /// <summary>
        /// Revert most recent change
        /// </summary>
        private void revertMenuItem_Click( object sender, System.EventArgs e )
        {
            HistoryImage img = _historyManager.Revert();
            if(img != null)
            {
                pictureBox.Image = img.Image;
                UpdateGui();
            }
        }

        /// <summary>
        /// Redo most recent reverted change
        /// </summary>
        private void redoMenuItem_Click( object sender, System.EventArgs e )
        {
            HistoryImage img = _historyManager.Revert();
            if( img != null )
            {
                pictureBox.Image = img.Image;
                UpdateGui();
            }
        }

        /// <summary>
        /// Exits the app
        /// </summary>
        private void exitMenuItem_Click( object sender, System.EventArgs e )
        {
            Application.Exit();
        }

        /// <summary>
        /// Saves image using filedialog
        /// </summary>
        private void saveAsMenuItem_Click( object sender, System.EventArgs e )
        {
            SaveImgAs();
        }

        
        [DllImport( "user32.DLL", EntryPoint = "ReleaseCapture" )]
        private extern static void ReleaseCapture();
        [DllImport( "user32.DLL", EntryPoint = "SendMessage" )]
        private extern static void SendMessage( IntPtr hWnd, int wMsg, int wParam, int lParam );

        /// <summary>
        /// Drag form on custom titlebar
        /// </summary>
        private void panelTitlebar_MouseDown( object sender, MouseEventArgs e )
        {
            ReleaseCapture();
            SendMessage( this.Handle, 0x112, 0xf012, 0 );
        }

        private void icnBtnMinimize_Click( object sender, EventArgs e )
        {
            WindowState = FormWindowState.Minimized;
        }

        private void icnBtnMaximize_Click( object sender, EventArgs e )
        {
            if( WindowState == FormWindowState.Normal )
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void icnBtnClose_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }
    }
}
