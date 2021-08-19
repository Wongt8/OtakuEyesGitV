using System;
using System.Diagnostics;
using HtmlAgilityPack;

namespace OtakuEyes {
    public class Scraper {

        private String animeName;

        private string[] SITE = new string[4] {"https://manga-anime-vostfr.com/?s=","http://www.mavanimes.co/?s=", 
                                    "https://www3.animesvostfr.net/?s=", "http://animeresistance.co/search?q="};
        public Scraper(String name) {
            this.animeName = name;
        }
        public bool search() {

            for(int i = 0;i < this.SITE.Length;i++) 
                {

                string url = this.SITE[i] + createURL(this.animeName);

                if (i == 0) {
                    if(mangaAnime(url)) {
                        openBrowser(url);
                        return true;
                    }
                }

                else if(i == 1) {
                    if(mavAnime(url)) {
                        openBrowser(url);
                        return true;
                    }
                }
                else if (i == 2) {
                    if(animesVostFr(url)) {
                        openBrowser(url);
                        return true;
                    }
                }
                else if (i == 3) {
                    if(animeResistance(url)) {
                        openBrowser(url);
                        return true;
                    }
                }
            }

            return false;
        }

        
        public void openBrowser(string url) {
            var psi = new ProcessStartInfo {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        public string createURL(String anime) {
            return anime.Replace(" ", "+");
        }

        public bool mangaAnime(string url) {
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var div = doc.DocumentNode.SelectNodes("//div[@class='no-result animation-2']");
            return div == null;
        }

        public bool mavAnime(string url) {
            // If true then anime on the website else no anime
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var article = doc.DocumentNode.SelectNodes("//*[@id='post-0']");
            if (article == null) {
                var h1 = doc.DocumentNode.SelectNodes("//h1[@class='entry-title']");
                return h1 != null;
            }
            return false;
            
        }

        public bool animesVostFr(string url) {
            // If true then anime on the website else no anime
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var h5 = doc.DocumentNode.SelectNodes("//*[@id='main']/div/div[2]/div/div[2]/h5");
            return h5 == null;
        }

        public bool animeResistance(string url) {
            // If true then anime on the website else no anime
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var div = doc.DocumentNode.SelectNodes("/html/body/div/div[2]/div[2]/div[1]/div[1]"); 
            return div != null;
        }
    }



}
