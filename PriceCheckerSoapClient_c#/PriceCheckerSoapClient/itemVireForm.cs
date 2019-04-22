using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PriceCheckerSoapClient.mstItemFinder;
using System.IO;

namespace PriceCheckerSoapClient
{
    public partial class itemVireForm : Form
    {
        public itemVireForm()
        {
            InitializeComponent();
        }
        
        public ItemFinder myItemsFinder = new ItemFinder();
        private ImageData myItemImageData = new ImageData();
        private ItemData myItemData = new ItemData();
        private ItemData[] myItemsList;
        
      
        private void btCheckBarcode_Click(object sender, EventArgs e)
        {
            GetItemData(tbBarcode.Text);
        }

        private void tbBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbBarcode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                GetItemData(tbBarcode.Text);
            }
        }
        private void GetItemData(string barcode)
        {
            myItemsList =  myItemsFinder.findItemsByBarcode(barcode);
            for (int i = 0; i < myItemsList.Count(); i++)
            {
                if (myItemsList.Count() > 1)
                {
                    myItemData = myItemsList[i];
                    myItemImageData = myItemData.itemImage;
                    lbItemName.Text = myItemData.itemName;
                    lbMeasure.Text = myItemData.itemMeasure;
                    lbPrice.Text = myItemData.itemPrice.ToString() + " лв.";
                    Image myImage = Base64ToImage(myItemImageData.imageStringData);
                    pixBox.Image = myImage;

                }
                else
                {
                    myItemData = myItemsList[i];
                    myItemImageData = myItemData.itemImage;
                    lbItemName.Text = myItemData.itemName;
                    lbMeasure.Text = myItemData.itemMeasure;
                    lbPrice.Text = myItemData.itemPrice.ToString() + " лв.";
                    Image myImage = Base64ToImage(myItemImageData.imageStringData);
                    pixBox.Image = myImage;
                }              
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create object for connection to the SOAP service
            
        }
    }
}
