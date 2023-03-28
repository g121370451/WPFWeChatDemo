using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFWeChatDemo.Controls
{
    /// <summary>
    /// LoginTypeButton.xaml 的交互逻辑
    /// </summary>
    public partial class LoginTypeButton : UserControl
    {
        public LoginTypeButton()
        {
            InitializeComponent();
        }

        public bool IsChecked { get; set; } = false;

        public string? Text1
        {
            get
            {
                return GetValue(Text1PathProperty) as string;
            }
            set
            {
                SetValue(Text1PathProperty, value);
            }
        }

        // 当外部绑定后,数据变化时,界面更新
        public static readonly DependencyProperty Text1PathProperty =
            DependencyProperty.Register("Text1", typeof(string), typeof(LoginTypeButton), new PropertyMetadata(null, (s, e) =>
            {
                ((LoginTypeButton)s).Text1 = (string)e.NewValue;
            }));

        public string? ImageSourcePath
        {
            get
            {
                return GetValue(ImageSourcePathProperty) as string;
            }
            set
            {
                SetValue(ImageSourcePathProperty, value);
            }
        }

        // 当外部绑定后,数据变化时,界面更新
        public static readonly DependencyProperty ImageSourcePathProperty =
            DependencyProperty.Register("ImageSourcePath", typeof(string), typeof(LoginTypeButton), new PropertyMetadata(null, (s, e) =>
            {
                ((LoginTypeButton)s).ImageSourcePath = (string)e.NewValue;
            }));

        public string? ImageWidth
        {
            get
            {
                return (string)GetValue(ImageWidthProperty);
            }
            set
            {
                SetValue(ImageWidthProperty, value);
            }
        }

        public string? ImageHeight
        {
            get
            {
                return (string)GetValue(ImageHeightProperty);
            }
            set
            {
                SetValue(ImageHeightProperty, value);
            }
        }

        // 当外部绑定后,数据变化时,界面更新
        public static readonly DependencyProperty ImageWidthProperty =
            DependencyProperty.Register("ImageWidthProperty", typeof(string), typeof(LoginTypeButton), new PropertyMetadata(null, (s, e) =>
            {
                ((LoginTypeButton)s).ImageWidth = (string)e.NewValue;
            }));

        // 当外部绑定后,数据变化时,界面更新
        public static readonly DependencyProperty ImageHeightProperty =
            DependencyProperty.Register("ImageHeightProperty", typeof(string), typeof(LoginTypeButton), new PropertyMetadata(null, (s, e) =>
            {
                ((LoginTypeButton)s).ImageHeight = (string)e.NewValue;
            }));
    }
}
