﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MCMAIP.Models
{
    public class SampleData:DropCreateDatabaseIfModelChanges<MCMAIPEntities>
    {
        public void SeedData(MCMAIPEntities context)
        {
            //new List<News>
            //{
            //    new News {
            //        Id = 1,
            //        DateCreated = "2016-8-25",
            //        Title = "南京微软云暨移动应用孵化平台首期创业团队招募",
            //        ImgUrl = "Upload/news/20160811145048_7196.jpg",
            //        Decs = "南京微软云暨移动应用孵化平台依托微软品牌的号召力及技术支撑，享受政府的优惠政策，引入优秀的创投基金，通过专业化运营管理，为入驻企业及创业者提供多方位创业资源支持与服务。"
            //    },
            //    new News {
            //        Id = 2,
            //        DateCreated = "2016-6-13",
            //        Title = "“小鹿创萌”华东区精英创梦大赛正式启动",
            //        ImgUrl = "Upload/news/2016082602.jpg",
            //        Decs = "由南京微软云暨移动应用孵化平台运营管理公司南京小鹿创萌科技孵化器运营管理有限公司冠名的“小鹿创萌”华东区精英创梦大赛于2016年9月9日正式启动。"
            //    },
            //    new News {
            //        Id = 3,
            //        DateCreated = "2016-05-01",
            //        Title = "南京经济技术开发区携手微软，共同打造智能制造产业孵化基地",
            //        ImgUrl = "Upload/news/2016082603.jpg",
            //        Decs = "2016年6月1日，南京经济技术开发区管委会与微软（中国）有限公司在北京香格里拉酒店签订了战略合作备忘录，宣布联手引入“云暨移动应用孵化平台”计划。 "
            //    }
            //}.ForEach(a => context.NewsList.Add(a));
            //base.Seed(context);


            context.NewsList = new List<News>
            {
                new News {
                    Id = 1,
                    DateCreated = "2016-8-25",
                    Title = "南京微软云暨移动应用孵化平台首期创业团队招募",
                    ImgUrl = "Upload/news/20160811145048_7196.jpg",
                    Decs = "南京微软云暨移动应用孵化平台依托微软品牌的号召力及技术支撑，享受政府的优惠政策，引入优秀的创投基金，通过专业化运营管理，为入驻企业及创业者提供多方位创业资源支持与服务。"
                },
                new News {
                    Id = 2,
                    DateCreated = "2016-6-13",
                    Title = "“小鹿创萌”华东区精英创梦大赛正式启动",
                    ImgUrl = "Upload/news/2016082602.jpg",
                    Decs = "由南京微软云暨移动应用孵化平台运营管理公司南京小鹿创萌科技孵化器运营管理有限公司冠名的“小鹿创萌”华东区精英创梦大赛于2016年9月9日正式启动。"
                },
                new News {
                    Id = 3,
                    DateCreated = "2016-05-01",
                    Title = "南京经济技术开发区携手微软，共同打造智能制造产业孵化基地",
                    ImgUrl = "Upload/news/2016082603.jpg",
                    Decs = "2016年6月1日，南京经济技术开发区管委会与微软（中国）有限公司在北京香格里拉酒店签订了战略合作备忘录，宣布联手引入“云暨移动应用孵化平台”计划。 "
                }
            };
        }
    }
}