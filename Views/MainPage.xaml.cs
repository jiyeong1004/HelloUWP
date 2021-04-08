using System;

using HelloUWP.ViewModels;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace HelloUWP.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }

        // 즉각 실행되는 게 아니라 준비될때 실행됨
        private async void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var myDlg = new MessageDialog("안녕하");  // 컴파일 시점에 메세지 다이얼로그로 바꿔친다.
            myDlg.Commands.Add(new UICommand("OK"));
            myDlg.Commands.Add(new UICommand("안OK"));
            myDlg.Commands.Add(new UICommand("싫음"));
            await myDlg.ShowAsync();  /* 파일을 다 읽을때까지(준비될 때까지) 다른 작업을 할 수 있다.
                                                            => 자원의 1%까지 끌어들일 수 있다. => 비동기식 */
        }
    }
}
