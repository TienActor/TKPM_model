using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyFolder root, images, css, js;
            MyFile readme, avatar, fav, style, app;
            root = new MyFolder("root");
            images = new MyFolder("images");
            css = new MyFolder("css");
            js = new MyFolder("js");
            readme = new MyFile("readme.md");
            avatar = new MyFile("avatar.png");
            fav = new MyFile("fav.ico");
            style = new MyFile("style.css");
            app = new MyFile("app.js");
            root.Add(images);
            root.Add(css);
            root.Add(js);
            root.Add(readme);
            images.Add(avatar);
            images.Add(fav);
            css.Add(style);
            js.Add(app);
            root.List();
            images.List();
            //avatar.List();


            Console.ReadKey();
        }
    }
}
