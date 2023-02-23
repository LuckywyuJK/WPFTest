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

namespace WY.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //第一步:声明依赖属性
        //依赖属性必须注册在依赖对象中（继承DependencyObject）
        public static readonly DependencyProperty VlueProperty;
        //第二步：注册,通过new PropertyMetadata给依赖属性一个默认值
        static MainWindow()
        {
            VlueProperty = DependencyProperty.Register("VlueProperty", typeof(double),typeof(MainWindow),new PropertyMetadata(1.0,));
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        //第三步：属性包装
        public double Vlue
        {
            get { return (double)this.GetValue(VlueProperty); }
            set { this.SetValue(VlueProperty,1.0); }
        }

    }
}
