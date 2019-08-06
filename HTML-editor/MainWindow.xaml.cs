using System;
using System.Windows;
using System.Windows.Forms;

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

        private void BtnUnderline_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("Underline", false, null);
        }

        private void BtnItalic_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("Italic", false, null);
        }

        private void BtnLeft_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("JustifyLeft", false, null);
        }

        private void BtnCenter_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("JustifyCenter", false, null);
        }

        private void BtnJustify_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("JustifyFull", false, null);
        }

        private void BtnRight_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("JustifyRight", false, null);
        }

        private void BtnIndent_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("Indent", false, null);
        }

        private void BtnOutdent_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("Outdent", false, null);
        }

        private void BtnBullets_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("InsertUnorderedList", false, null);
        }

        private void BtnNumeric_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("InsertOrderedList", false, null);
        }

        private void BtnBackColor_Click(object sender, RoutedEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() !=  System.Windows.Forms.DialogResult.Cancel)
            {
                doc.execCommand("BackColor", false, System.Drawing.ColorTranslator.ToHtml(colorDialog.Color).ToString());
            }
            
        }

        private void BtnForeColor_Click(object sender, RoutedEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                doc.execCommand("ForeColor", false, System.Drawing.ColorTranslator.ToHtml(colorDialog.Color).ToString());
            }
        }

        private void BtnLink_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("CreateLink", true, null);
        }

        private void BtnRemoveLink_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("Unlink", true, null);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            doc.execCommand("FontSize", true, 1);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            doc.execCommand("FontSize", true, 2);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            doc.execCommand("FontSize", true, 3);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            doc.execCommand("FontSize", true, 4);
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            doc.execCommand("FontSize", true, 5);
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            doc.execCommand("FontSize", true, 6);
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            doc.execCommand("FontSize", true, 7);
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            doc.execCommand("FontName", true, "Verdana");
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            doc.execCommand("FontName", true, "Arial");
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            doc.execCommand("FontName", true, "Times New Roman");
        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            doc.execCommand("FontName", true, "Currier New");
        }

        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            doc.execCommand("FontName", true, "Cambria");
        }

        private void MenuItem_Click_12(object sender, RoutedEventArgs e)
        {
            doc.execCommand("FontName", true, "Tahoma");
        }

        private void MenuItem_Click_13(object sender, RoutedEventArgs e)
        {
            doc.execCommand("FontName", true, "Book Antiqua");
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {
                System.IO.File.WriteAllText(save.FileName, doc.body.innerHTML);
            }
        }
    }
}
