using System.Windows.Forms;

namespace ImageEditor
{
    public class EffectFormBase : Form
    {
        protected HistoryImage _originalImg;
        public HistoryImage Img { get; protected set; }
    }
}
