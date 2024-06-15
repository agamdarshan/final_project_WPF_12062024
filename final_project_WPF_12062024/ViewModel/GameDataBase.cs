using final_project_WPF_12062024.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project_WPF_12062024.ViewModel
{
    public class GameDataBase
    {
        // Create a static list of trivia questions to serve as a shared in-memory database
        private static List<GameDataModel> _questionsList = new List<GameDataModel>
        {
            new GameDataModel
            {
                Question = "מה צבע השמים ביום בהיר?",
                Option1 = "כחול",
                Option2 = "אדום",
                Option3 = "ירוק",
                Option4 = "צהוב",
                Answer = "כחול",
                Level = "רמה 1"
            },
            new GameDataModel
            {
                Question = "מהו הפרי שמתחיל באות ת?",
                Option1 = "תפוח",
                Option2 = "בננה",
                Option3 = "ענבים",
                Option4 = "אבטיח",
                Answer = "תפוח",
                Level = "רמה 1"
            },
            new GameDataModel
            {
                Question = "מהי בירת ישראל?",
                Option1 = "תל אביב",
                Option2 = "ירושלים",
                Option3 = "חיפה",
                Option4 = "באר שבע",
                Answer = "ירושלים",
                Level = "רמה 1"
            },
            new GameDataModel
            {
                Question = "איזה יום בשבוע הוא הראשון?",
                Option1 = "שני",
                Option2 = "ראשון",
                Option3 = "שלישי",
                Option4 = "שבת",
                Answer = "ראשון",
                Level = "רמה 1"
            },
            new GameDataModel
            {
                Question = "איזה חיה נובחת?",
                Option1 = "כלב",
                Option2 = "חתול",
                Option3 = "דג",
                Option4 = "ציפור",
                Answer = "כלב",
                Level = "רמה 1"
            },
            new GameDataModel
            {
                Question = "מהי החיה הגדולה ביותר בעולם?",
                Option1 = "פיל",
                Option2 = "לוויתן כחול",
                Option3 = "קרנף",
                Option4 = "כריש",
                Answer = "לוויתן כחול",
                Level = "רמה 2"
            },
            new GameDataModel
            {
                Question = "מי כתב את הספר 'הארי פוטר'?",
                Option1 = "ג'יי קיי רולינג",
                Option2 = "ריק ריירדן",
                Option3 = "טולקין",
                Option4 = "ג'ורג' מרטין",
                Answer = "ג'יי קיי רולינג",
                Level = "רמה 2"
            },
            new GameDataModel
            {
                Question = "מהי היבשת הגדולה ביותר?",
                Option1 = "אפריקה",
                Option2 = "אסיה",
                Option3 = "אירופה",
                Option4 = "אמריקה הצפונית",
                Answer = "אסיה",
                Level = "רמה 2"
            },
            new GameDataModel
            {
                Question = "איזה גז משמש בנשימה של בני אדם?",
                Option1 = "חמצן",
                Option2 = "פחמן דו-חמצני",
                Option3 = "מימן",
                Option4 = "הליום",
                Answer = "חמצן",
                Level = "רמה 2"
            },
            new GameDataModel
            {
                Question = "באיזה שנה נוסדה מדינת ישראל?",
                Option1 = "1945",
                Option2 = "1948",
                Option3 = "1950",
                Option4 = "1967",
                Answer = "1948",
                Level = "רמה 2"
            },
            new GameDataModel
            {
                Question = "איזה יסוד כימי מסומן באותיות H2O?",
                Option1 = "מים",
                Option2 = "מימן",
                Option3 = "חמצן",
                Option4 = "חומצה",
                Answer = "מים",
                Level = "רמה 3"
            },
            new GameDataModel
            {
                Question = "איזה כוכב לכת הוא הקרוב ביותר לשמש?",
                Option1 = "נוגה",
                Option2 = "כדור הארץ",
                Option3 = "מרקורי",
                Option4 = "מאדים",
                Answer = "מרקורי",
                Level = "רמה 3"
            },
            new GameDataModel
            {
                Question = "באיזה שנה נפלה חומת ברלין?",
                Option1 = "1989",
                Option2 = "1990",
                Option3 = "1991",
                Option4 = "1992",
                Answer = "1989",
                Level = "רמה 3"
            },
            new GameDataModel
            {
                Question = "מי המציא את נורת החשמל?",
                Option1 = "תומס אדיסון",
                Option2 = "אלברט איינשטיין",
                Option3 = "ניקולה טסלה",
                Option4 = "ג'יימס ווטסון",
                Answer = "תומס אדיסון",
                Level = "רמה 3"
            },
            new GameDataModel
            {
                Question = "מהי השפה המדוברת ביותר בעולם?",
                Option1 = "אנגלית",
                Option2 = "סינית מנדרינית",
                Option3 = "ספרדית",
                Option4 = "ערבית",
                Answer = "סינית מנדרינית",
                Level = "רמה 3"
            },
            new GameDataModel
            {
                Question = "מי כתב את הסימפוניה התשיעית?",
                Option1 = "מוצרט",
                Option2 = "בטהובן",
                Option3 = "באך",
                Option4 = "שוברט",
                Answer = "בטהובן",
                Level = "רמה 4"
            },
            new GameDataModel
            {
                Question = "באיזה שנה החלה מלחמת העולם השנייה?",
                Option1 = "1935",
                Option2 = "1937",
                Option3 = "1939",
                Option4 = "1941",
                Answer = "1939",
                Level = "רמה 4"
            },
            new GameDataModel
            {
                Question = "מהו היסוד הכימי המסומן באות C?",
                Option1 = "פחמן",
                Option2 = "נחושת",
                Option3 = "כלור",
                Option4 = "כספית",
                Answer = "פחמן",
                Level = "רמה 4"
            },
            new GameDataModel
            {
                Question = "איזה מדינה ידועה במגדל אייפל?",
                Option1 = "איטליה",
                Option2 = "צרפת",
                Option3 = "ספרד",
                Option4 = "גרמניה",
                Answer = "צרפת",
                Level = "רמה 4"
            },
            new GameDataModel
            {
                Question = "מי כתב את הספר 'מדעי הקודש'?",
                Option1 = "הרמב\"ם",
                Option2 = "הרב קוק",
                Option3 = "רבי יהודה הלוי",
                Option4 = "רבי נחמן מברסלב",
                Answer = "הרמב\"ם",
                Level = "רמה 4"
            },
            new GameDataModel
            {
                Question = "באיזה שנה פרצה המהפכה הצרפתית?",
                Option1 = "1787",
                Option2 = "1789",
                Option3 = "1791",
                Option4 = "1793",
                Answer = "1789",
                Level = "רמה 5"
            },
            new GameDataModel
            {
                Question = "מי גילה את אמריקה?",
                Option1 = "קולומבוס",
                Option2 = "מגלאן",
                Option3 = "קפטן קוק",
                Option4 = "וספוצ'י",
                Answer = "קולומבוס",
                Level = "רמה 5"
            },
            new GameDataModel
            {
                Question = "מהי הסופרנובה?",
                Option1 = "סוג של גלקסיה",
                Option2 = "פיצוץ של כוכב",
                Option3 = "כוכב נופל",
                Option4 = "סוג של כוכב לכת",
                Answer = "פיצוץ של כוכב",
                Level = "רמה 5"
            },
            new GameDataModel
            {
                Question = "מי היה הכימאי שהמציא את הטבלה המחזורית?",
                Option1 = "דמיטרי מנדלייב",
                Option2 = "אלברט איינשטיין",
                Option3 = "מארי קירי",
                Option4 = "נילס בוהר",
                Answer = "דמיטרי מנדלייב",
                Level = "רמה 5"
            },
            new GameDataModel
            {
                Question = "איזה גז משמש למילוי בלוני הליום?",
                Option1 = "חמצן",
                Option2 = "פחמן דו-חמצני",
                Option3 = "מימן",
                Option4 = "הליום",
                Answer = "הליום",
                Level = "רמה 5"
            },
        };

        // Property to access the questions list
        public static List<GameDataModel> QuestionsList
        {
            get { return _questionsList; }
            set { _questionsList = value; }
        }
    }
}
