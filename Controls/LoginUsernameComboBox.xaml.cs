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
    /// LoginUsernameComboBox.xaml 的交互逻辑
    /// </summary>
    public partial class LoginUsernameComboBox : UserControl
    {
        public LoginUsernameComboBox()
        {
            InitializeComponent();
        }
        public string? ComboBoxWidth
        {
            get
            {
                return (string)GetValue(ComboBoxWidthProperty);
            }
            set
            {
                SetValue(ComboBoxWidthProperty, value);
            }
        }

        public string? ComboBoxHeight
        {
            get
            {
                return (string)GetValue(ComboBoxHeightProperty);
            }
            set
            {
                SetValue(ComboBoxHeightProperty, value);
            }
        }

        // 当外部绑定后,数据变化时,界面更新
        public static readonly DependencyProperty ComboBoxWidthProperty =
            DependencyProperty.Register("ComboBoxWidthProperty", typeof(string), typeof(LoginUsernameComboBox), new PropertyMetadata(null, (s, e) =>
            {
                ((LoginUsernameComboBox)s).ComboBoxWidth = (string)e.NewValue;
            }));

        // 当外部绑定后,数据变化时,界面更新
        public static readonly DependencyProperty ComboBoxHeightProperty =
            DependencyProperty.Register("ComboBoxHeightProperty", typeof(string), typeof(LoginUsernameComboBox), new PropertyMetadata(null, (s, e) =>
            {
                ((LoginUsernameComboBox)s).ComboBoxHeight = (string)e.NewValue;
            }));
    }
}
