// using System;
// using System.Collections.Generic;
// using System.Collections.ObjectModel;
// using System.Web.UI.WebControls;
// using System.Collections;
//
// namespace Test.Models
// {
//     public class CatConverter : JavaScriptConverter
//     {
//         public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
//         {
//             Cat cat = obj as Cat;
//
//             if(cat != null)
//             {
//                 Dictionary<string, object> result = new Dictionary<string, object>(){
//                     {"name", cat.name},
//                     {"breed", cat.breed},
//                     {"age", cat.age},
//                     {"canFly", cat.canFly},
//                     {"favoriteFoods", cat.favoriteFoods},
//                     {"data", cat.data}
//                 };
//                 return result;
//             }
//             return new Dictionary<string,object>();
//         }
//
//         public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
//         {
//             return new Cat("Catto");
//         }
//     }
// }
