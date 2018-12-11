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
using PrismUnityTest.Views;
using Prism.Ioc;
using Prism.Regions;
namespace PrismUnityTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        IContainerExtension _container;
        IRegionManager _regionManager;

        UserControl _viewA;
        UserControl _viewB;
        IRegion _region;
        public MainWindow(IRegionManager regionManager, IContainerExtension container)
        {
            InitializeComponent();
            _regionManager = regionManager;
            _container = container;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _region.Activate(_viewA);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _region.Deactivate(_viewA);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _region.Activate(_viewB);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            _region.Deactivate(_viewB);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _viewA = _container.Resolve<ViewA>();
            _viewB = _container.Resolve<ViewB>();
            _region = _regionManager.Regions["ContentInner"];
            _region.Add(_viewA);
            _region.Add(_viewB);
           
        }
    }
}
