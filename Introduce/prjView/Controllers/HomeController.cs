using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjView.Models;

namespace prjView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<IntroDuction> introductions = new List<IntroDuction>();
            introductions.Add(new IntroDuction { id = "1", name = "籃球", Introduction = "籃球，為一種由兩隊參與，在一個長方形籃球場進行的球類運動。每隊出場5名隊員，可將球向任何方向傳、投、拍、滾或運，目的是將籃球投入對方球籃得分，並阻止對方獲得控球權或得分。" });
            introductions.Add(new IntroDuction { id = "2", name = "上低音號", Introduction = "上低音號泛指一群音域與長號相同，但具有三個以上按鍵的銅管樂器，一般由黃銅、磷銅等製成，常見於管樂團編制中,初學者大多都用低音譜，只有少數才用高音譜。上低音號形狀比低音號小一些，音域和次中音長號相同，比低音號高八度，比小號低八度。" });
            introductions.Add(new IntroDuction { id = "3", name = "競技啦啦隊", Introduction = "競技啦啦隊（Cheerleading）是啦啦隊的一種，是一種充滿活力的競賽運動，是結合體操、跳躍、特技、口號及舞蹈編排的複合式運動。之所以有「競技」兩字，是因為它本身將體操融入，進而發展出專項的競賽項目。" });
          

            return View(introductions);
        }
    }
}