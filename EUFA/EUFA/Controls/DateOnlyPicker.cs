using System.ComponentModel;
using System.Windows.Forms;

namespace EUFA.Controls
{
    [ToolboxItem(true)]
    public class DateOnlyPicker : DateTimePicker
    {
        public DateOnlyPicker()
        {
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "dd.MM.yy";
        }
    }
}
