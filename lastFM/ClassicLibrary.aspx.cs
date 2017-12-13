using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

//api key 73000bcbfd0723bbaf4a69f311e35a44

namespace lastFM
{
    public partial class ClassicLibrary : System.Web.UI.Page
    {
        static int count = 1;
        static string username;
        string url;

        protected void Button1_Click(object sender, EventArgs e)
        {
            count = 1;
            username = TextBox1.Text;
            Label22.Text = "Page " + count.ToString();
            prevButton.Text = "Prev";
            nextButton.Text = "Next";
            url = "http://ws.audioscrobbler.com/2.0/?method=library.getartists&api_key=73000bcbfd0723bbaf4a69f311e35a44&user=" + username + "&limit=18&page=" + count;

            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            XmlNodeList artist = doc.GetElementsByTagName("artist");
            XmlNodeList user = doc.GetElementsByTagName("artists");

            Label19.Text = user[0].Attributes["user"].Value + "'s Classic Library";
            Label22.Text = "Page " + count.ToString();
            prevButton.Text = "Prev";
            nextButton.Text = "Next";

            //row 1
            Label1.Text = artist[0].FirstChild.InnerText + " (" + artist[0].FirstChild.NextSibling.InnerText + " plays)";
            Label2.Text = artist[1].FirstChild.InnerText + " (" + artist[1].FirstChild.NextSibling.InnerText + " plays)";
            Label3.Text = artist[2].FirstChild.InnerText + " (" + artist[2].FirstChild.NextSibling.InnerText + " plays)";
            Label4.Text = artist[3].FirstChild.InnerText + " (" + artist[3].FirstChild.NextSibling.InnerText + " plays)";
            Label5.Text = artist[4].FirstChild.InnerText + " (" + artist[4].FirstChild.NextSibling.InnerText + " plays)";
            Label6.Text = artist[5].FirstChild.InnerText + " (" + artist[5].FirstChild.NextSibling.InnerText + " plays)";
            Image1.ImageUrl = artist[0].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image2.ImageUrl = artist[1].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image3.ImageUrl = artist[2].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image4.ImageUrl = artist[3].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image5.ImageUrl = artist[4].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image6.ImageUrl = artist[5].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;

            //row 2
            Label7.Text = artist[6].FirstChild.InnerText + " (" + artist[6].FirstChild.NextSibling.InnerText + " plays)";
            Label8.Text = artist[7].FirstChild.InnerText + " (" + artist[7].FirstChild.NextSibling.InnerText + " plays)";
            Label9.Text = artist[8].FirstChild.InnerText + " (" + artist[8].FirstChild.NextSibling.InnerText + " plays)";
            Label10.Text = artist[9].FirstChild.InnerText + " (" + artist[9].FirstChild.NextSibling.InnerText + " plays)";
            Label11.Text = artist[10].FirstChild.InnerText + " (" + artist[10].FirstChild.NextSibling.InnerText + " plays)";
            Label12.Text = artist[11].FirstChild.InnerText + " (" + artist[11].NextSibling.FirstChild.NextSibling.InnerText + " plays)";
            Image7.ImageUrl = artist[6].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image8.ImageUrl = artist[7].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image9.ImageUrl = artist[8].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image10.ImageUrl = artist[9].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image11.ImageUrl = artist[10].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image12.ImageUrl = artist[11].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;

            //row 3
            Label13.Text = artist[12].FirstChild.InnerText + " (" + artist[12].FirstChild.NextSibling.InnerText + " plays)";
            Label14.Text = artist[13].FirstChild.InnerText + " (" + artist[13].FirstChild.NextSibling.InnerText + " plays)";
            Label15.Text = artist[14].FirstChild.InnerText + " (" + artist[14].FirstChild.NextSibling.InnerText + " plays)";
            Label16.Text = artist[15].FirstChild.InnerText + " (" + artist[15].FirstChild.NextSibling.InnerText + " plays)";
            Label17.Text = artist[16].FirstChild.InnerText + " (" + artist[16].FirstChild.NextSibling.InnerText + " plays)";
            Label18.Text = artist[17].FirstChild.InnerText + " (" + artist[17].FirstChild.NextSibling.InnerText + " plays)";
            Image13.ImageUrl = artist[12].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image14.ImageUrl = artist[13].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image15.ImageUrl = artist[14].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image16.ImageUrl = artist[15].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image17.ImageUrl = artist[16].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image18.ImageUrl = artist[17].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
        }

        protected void nextButton_Click(object sender, EventArgs e)
        {
            count++;
            Label22.Text = "Page " + count.ToString();
            prevButton.Text = "Prev";
            nextButton.Text = "Next";
            url = "http://ws.audioscrobbler.com/2.0/?method=library.getartists&api_key=73000bcbfd0723bbaf4a69f311e35a44&user=" + username + "&limit=18&page=" + count;

            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            XmlNodeList artist = doc.GetElementsByTagName("artist");

            //row 1
            Label1.Text = artist[0].FirstChild.InnerText + " (" + artist[0].FirstChild.NextSibling.InnerText + ")";
            Label2.Text = artist[1].FirstChild.InnerText + " (" + artist[1].FirstChild.NextSibling.InnerText + ")";
            Label3.Text = artist[2].FirstChild.InnerText + " (" + artist[2].FirstChild.NextSibling.InnerText + ")";
            Label4.Text = artist[3].FirstChild.InnerText + " (" + artist[3].FirstChild.NextSibling.InnerText + ")";
            Label5.Text = artist[4].FirstChild.InnerText + " (" + artist[4].FirstChild.NextSibling.InnerText + ")";
            Label6.Text = artist[5].FirstChild.InnerText + " (" + artist[5].FirstChild.NextSibling.InnerText + ")";
            Image1.ImageUrl = artist[0].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image2.ImageUrl = artist[1].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image3.ImageUrl = artist[2].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image4.ImageUrl = artist[3].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image5.ImageUrl = artist[4].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image6.ImageUrl = artist[5].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;

            //row 2
            Label7.Text = artist[6].FirstChild.InnerText + " (" + artist[6].FirstChild.NextSibling.InnerText + ")";
            Label8.Text = artist[7].FirstChild.InnerText + " (" + artist[7].FirstChild.NextSibling.InnerText + ")";
            Label9.Text = artist[8].FirstChild.InnerText + " (" + artist[8].FirstChild.NextSibling.InnerText + ")";
            Label10.Text = artist[9].FirstChild.InnerText + " (" + artist[9].FirstChild.NextSibling.InnerText + ")";
            Label11.Text = artist[10].FirstChild.InnerText + " (" + artist[10].FirstChild.NextSibling.InnerText + ")";
            Label12.Text = artist[11].FirstChild.InnerText + " (" + artist[11].NextSibling.FirstChild.NextSibling.InnerText + ")";
            Image7.ImageUrl = artist[6].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image8.ImageUrl = artist[7].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image9.ImageUrl = artist[8].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image10.ImageUrl = artist[9].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image11.ImageUrl = artist[10].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image12.ImageUrl = artist[11].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;

            //row 3
            Label13.Text = artist[12].FirstChild.InnerText + " (" + artist[12].FirstChild.NextSibling.InnerText + ")";
            Label14.Text = artist[13].FirstChild.InnerText + " (" + artist[13].FirstChild.NextSibling.InnerText + ")";
            Label15.Text = artist[14].FirstChild.InnerText + " (" + artist[14].FirstChild.NextSibling.InnerText + ")";
            Label16.Text = artist[15].FirstChild.InnerText + " (" + artist[15].FirstChild.NextSibling.InnerText + ")";
            Label17.Text = artist[16].FirstChild.InnerText + " (" + artist[16].FirstChild.NextSibling.InnerText + ")";
            Label18.Text = artist[17].FirstChild.InnerText + " (" + artist[17].FirstChild.NextSibling.InnerText + ")";
            Image13.ImageUrl = artist[12].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image14.ImageUrl = artist[13].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image15.ImageUrl = artist[14].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image16.ImageUrl = artist[15].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image17.ImageUrl = artist[16].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            Image18.ImageUrl = artist[17].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
        }

        protected void prevButton_Click(object sender, EventArgs e)
        {
            count--;
            prevButton.Text = "Prev";
            nextButton.Text = "Next";

            if (count < 1)
            {
                count = 1;
                Label22.Text = "Page " + count.ToString();
                url = "http://ws.audioscrobbler.com/2.0/?method=library.getartists&api_key=73000bcbfd0723bbaf4a69f311e35a44&user=" + username + "&limit=18&page=1";
            }
            else
            {
                Label22.Text = "Page " + count.ToString();
                url = "http://ws.audioscrobbler.com/2.0/?method=library.getartists&api_key=73000bcbfd0723bbaf4a69f311e35a44&user=" + username + "&limit=18&page=" + count;

                XmlDocument doc = new XmlDocument();
                doc.Load(url);
                XmlNodeList artist = doc.GetElementsByTagName("artist");

                //row 1
                Label1.Text = artist[0].FirstChild.InnerText + " (" + artist[0].FirstChild.NextSibling.InnerText + ")";
                Label2.Text = artist[1].FirstChild.InnerText + " (" + artist[1].FirstChild.NextSibling.InnerText + ")";
                Label3.Text = artist[2].FirstChild.InnerText + " (" + artist[2].FirstChild.NextSibling.InnerText + ")";
                Label4.Text = artist[3].FirstChild.InnerText + " (" + artist[3].FirstChild.NextSibling.InnerText + ")";
                Label5.Text = artist[4].FirstChild.InnerText + " (" + artist[4].FirstChild.NextSibling.InnerText + ")";
                Label6.Text = artist[5].FirstChild.InnerText + " (" + artist[5].FirstChild.NextSibling.InnerText + ")";
                Image1.ImageUrl = artist[0].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image2.ImageUrl = artist[1].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image3.ImageUrl = artist[2].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image4.ImageUrl = artist[3].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image5.ImageUrl = artist[4].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image6.ImageUrl = artist[5].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;

                //row 2
                Label7.Text = artist[6].FirstChild.InnerText + " (" + artist[6].FirstChild.NextSibling.InnerText + ")";
                Label8.Text = artist[7].FirstChild.InnerText + " (" + artist[7].FirstChild.NextSibling.InnerText + ")";
                Label9.Text = artist[8].FirstChild.InnerText + " (" + artist[8].FirstChild.NextSibling.InnerText + ")";
                Label10.Text = artist[9].FirstChild.InnerText + " (" + artist[9].FirstChild.NextSibling.InnerText + ")";
                Label11.Text = artist[10].FirstChild.InnerText + " (" + artist[10].FirstChild.NextSibling.InnerText + ")";
                Label12.Text = artist[11].FirstChild.InnerText + " (" + artist[11].NextSibling.FirstChild.NextSibling.InnerText + ")";
                Image7.ImageUrl = artist[6].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image8.ImageUrl = artist[7].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image9.ImageUrl = artist[8].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image10.ImageUrl = artist[9].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image11.ImageUrl = artist[10].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image12.ImageUrl = artist[11].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;

                //row 3
                Label13.Text = artist[12].FirstChild.InnerText + " (" + artist[12].FirstChild.NextSibling.InnerText + ")";
                Label14.Text = artist[13].FirstChild.InnerText + " (" + artist[13].FirstChild.NextSibling.InnerText + ")";
                Label15.Text = artist[14].FirstChild.InnerText + " (" + artist[14].FirstChild.NextSibling.InnerText + ")";
                Label16.Text = artist[15].FirstChild.InnerText + " (" + artist[15].FirstChild.NextSibling.InnerText + ")";
                Label17.Text = artist[16].FirstChild.InnerText + " (" + artist[16].FirstChild.NextSibling.InnerText + ")";
                Label18.Text = artist[17].FirstChild.InnerText + " (" + artist[17].FirstChild.NextSibling.InnerText + ")";
                Image13.ImageUrl = artist[12].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image14.ImageUrl = artist[13].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image15.ImageUrl = artist[14].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image16.ImageUrl = artist[15].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image17.ImageUrl = artist[16].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                Image18.ImageUrl = artist[17].FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
            }
        }


    }
}