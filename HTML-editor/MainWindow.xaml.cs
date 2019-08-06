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

namespace HTML_editor
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private mshtml.IHTMLDocument2 doc;
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            webBrowser.Navigate("about:blank");
            doc = (mshtml.IHTMLDocument2)webBrowser.Document;
            doc.designMode = "On";
            doc.execCommand("EditMode", false, null);

        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            doc.body.innerHTML = "";
        }

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("Print", true, null);
        }

        private void BtnCut_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                doc.execCommand("Cut", false, null);
            }
            catch (Exception)
            {
            }            
        }

        private void BtnCopy_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("Copy", false, null);
        }

        private void BtnPaste_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("Paste", false, null);
        }

        private void BtnBold_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("Bold", false, null);
        }
    }
}
