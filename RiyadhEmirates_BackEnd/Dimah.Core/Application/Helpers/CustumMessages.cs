
namespace Dimah.Core.Application.Interfaces.Helpers
{
    public static class CustumMessages
    {
        /// <summary>
        /// Returns Message When Save Successfully
        /// </summary>
        /// <returns></returns>
        public static string SaveSuccess()
        {
            return "success,عملية ناجحة,تم حفظ البيانات بنجاح";
        }
        /// <summary>
        /// Returns Message When Save Failed
        /// </summary>
        /// <returns></returns>
        public static string SaveFailed()
        {
            return "error,عملية غير ناجحة,فشل في حفظ البيانات";
        }

        /// <summary>
        /// Returns Message When Update Successfully
        /// </summary>
        /// <returns></returns>
        public static string UpdateSuccess()
        {
            return "success,عملية ناجحة,تم تعديل البيانات بنجاح";
        }
        /// <summary>
        /// Returns Message When Update Failed
        /// </summary>
        /// <returns></returns>
        public static string UpdateFailed()
        {
            return "error,عملية غير ناجحة,فشل في تعديل البيانات";
        }

        /// <summary>
        /// Returns Message When Delete Successfully
        /// </summary>
        /// <returns></returns>
        public static string DeleteSuccess()
        {
            return "success,عملية ناجحة,تم حذف البيانات بنجاح";
        }
        /// <summary>
        /// Returns Message When Delete Failed
        /// </summary>
        /// <returns></returns>
        public static string DeleteFailed()
        {
            return "error,عملية غير ناجحة,فشل في حذف البيانات";
        }

        /// <summary>
        /// Returns Message When Activate Successfully
        /// </summary>
        /// <returns></returns>
        public static string ActivateSuccess()
        {
            return "success,عملية ناجحة,تم تفعيل العنصر بنجاح";
        }
        /// <summary>
        /// Returns Message When Activate Failed
        /// </summary>
        /// <returns></returns>
        public static string ActivateFailed()
        {
            return "error,عملية غير ناجحة,فشل في تفعيل العنصر";
        }

        /// <summary>
        /// Returns Message When DeActivate Successfully
        /// </summary>
        /// <returns></returns>
        public static string DeActivateSuccess()
        {
            return "success,عملية ناجحة,تم ايقاف العنصر بنجاح";
        }
        /// <summary>
        /// Returns Message When DeActivate Failed
        /// </summary>
        /// <returns></returns>
        public static string DeActivateFailed()
        {
            return "error,عملية غير ناجحة,فشل في ايقاف العنصر";
        }

        /// <summary>
        /// Returns Message When SendMail Successfully
        /// </summary>
        /// <returns></returns>
        public static string SendMailSuccess()
        {
            return "success,عملية ناجحة,تم ارسال البريد الالكتروني بنجاح";
        }
        /// <summary>
        /// Returns Message When SendMail Failed
        /// </summary>
        /// <returns></returns>
        public static string SendMailFailed()
        {
            return "error,عملية غير ناجحة,فشل في ارسال البريد الالكتروني";
        }

        /// <summary>
        /// Returns Error Message 
        /// </summary>
        /// <param name="message">Message Appears</param>
        /// <returns></returns>
        public static string MsgError(string message)
        {
            return "error,عملية غير ناجحة," + message;
        }
        /// <summary>
        /// Returns Success Message 
        /// </summary>
        /// <param name="message">Message Appears</param>
        /// <returns></returns>
        public static string MsgSuccess(string message)
        {
            return "success,عملية ناجحة," + message;
        }
        /// <summary>
        /// Returns Information Message 
        /// </summary>
        /// <param name="message">Message Appears</param>
        /// <returns></returns>
        public static string MsgInfo(string message)
        {
            return "info,معلومة," + message;
        }
        /// <summary>
        /// Returns Warning Message 
        /// </summary>
        /// <param name="message">Message Appears</param>
        /// <returns></returns>
        public static string MsgWarning(string message)
        {
            return "warn,تنبيه," + message;
        }

        /// <summary>
        /// Return Message
        /// </summary>
        /// <param name="type">Type May Be success, warning, error, info</param>
        /// <param name="message">Message Appears</param>
        /// <returns></returns>
        public static string Msg(string type, string messagetitle, string message)
        {
            return type + "," + messagetitle + "," + message;
        }

        /// <summary>
        /// Returns Message When Send Request Successfully
        /// </summary>
        /// <returns></returns>
        public static string SendRequestSuccess()
        {
            return "success,عملية ناجحة,تم إرسال الطلب بنجاح";
        }
        /// <summary>
        /// Returns Message When Send Request Failed
        /// </summary>
        /// <returns></returns>
        public static string SendRequestFailed()
        {
            return "error,عملية غير ناجحة,فشل في إرسال الطلب";
        }

        /// <summary>
        /// Returns Message When Update Request Successfully
        /// </summary>
        /// <returns></returns>
        public static string UpdateRequestSuccess()
        {
            return "success,عملية ناجحة,تم تعديل بيانات الطلب بنجاح";
        }
        /// <summary>
        /// Returns Message When Update Request Failed
        /// </summary>
        /// <returns></returns>
        public static string UpdateRequestFailed()
        {
            return "error,عملية غير ناجحة,فشل في تعديل بيانات الطلب";
        }

        public static string MsgItemNotFound()
        {
            return "warn,تنبية,هذا العنصر غير موجود برجاء المحاولة مرة أخرى";
        }
        public static string IsExsistName()
        {
            return "warn,تنبية,هذا الاسم مضاف مسبقا";
        }
        public static string IsNotExsistItem()
        {
            return "error,تنبية,هذا العنصر غير مضاف على النظام";
        }
    }
}
