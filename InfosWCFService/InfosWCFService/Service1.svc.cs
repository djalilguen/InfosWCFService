using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace InfosWCFService
{
    public class Service1 : IService1
    {
        public List<Article> GetAllArticles(Article art)
        {
            return DataProvider.GetArticles();
        }

        public bool AddArticle(Article art)
        {
            return DataProvider.addArticle(art);
        }

    }
}
