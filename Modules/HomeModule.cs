using Nancy;
using WordCounter.Objects;

namespace WordCounterView
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/counter"] = _ =>
      {
        RepeatCounter countWords = new RepeatCounter(Request.Form["word"],
                                                    Request.Form["sentence"]);
        return View["result.cshtml", countWords];
      };
    }
  }
}
