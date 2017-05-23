using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.PropertyGridItems;
using TestStack.White.UIItems.WindowItems;

namespace CalculatorAutomationFramework.Common.Helpers
{
    public class WhiteHelper
    {
        #region ElementMethods
        //TextBox
        public static UIItem ReturnUiItemById(string id)
            => WindowDriver.Instance.Get<UIItem>(SearchCriteria.ByAutomationId(id));

        public static UIItem ReturnUiItemByName(string className) 
            => WindowDriver.Instance.Get<UIItem>(SearchCriteria.ByClassName(className));

        public static UIItem ReturnUiItemBy(string input)
            => WindowDriver.Instance.Get<UIItem>(SearchCriteria.ByText(input));

        #endregion

        //public static void EnterTextBoxText(TextBox textbox, string text)
        //{
        //    textbox.Text = text;
        //}

        //public static string GetWindowTitle(Window window)
        //{
        //    return window.Title;
        //}

        //public static string ReturnTextFromTextField(string id)
        //{
        //    return WindowDriver.Instance.Get<Label>(SearchCriteria.ByAutomationId(id)).Text;
        //}

        //public static string ReturnLabelText(Label label)
        //{
        //    return label.Text;
        //}



        ////Button
        //public static Button GetButton(string input)
        //{
        //    return (Button)WindowDriver.Instance.Get(SearchCriteria.ByText(input));
        //}

        //public static Menu GetMenu(string input)
        //{
        //    return (Menu)WindowDriver.Instance.Get(SearchCriteriaHelper.SearchByText(input));
        //}

        //public static void ButtonClick(Button button)
        //{
        //    button.Click();
        //}

        //public static void MenuClick(Menu menu)
        //{
        //    menu.Click();
        //}

        ////CheckBox 
        //public static bool CheckBoxIsSelected(CheckBox checkBox)
        //{
        //    return checkBox.IsSelected;
        //}

        //public bool IsFocused(CheckBox checkBox)
        //{
        //    return checkBox.IsFocussed;
        //}

        ////Label


        //public static ListItem GetListItem(string input)
        //{
        //    return (ListItem)WindowDriver.Instance.Get(SearchCriteriaHelper.SearchByText(input));
        //}

        ////Switching Windows
        //public static Window SwitchWindow(string newWindowTitle)
        //{
        //    return WindowDriver.SwitchWindow(newWindowTitle);
        //}

        ////Pane (Property Grid)
        //public static PropertyGrid GetPanel(string input)
        //{
        //    return (PropertyGrid)WindowDriver.Instance.Get(SearchCriteriaHelper.SearchByText(input));
        //}

        //#endregion
    }
}
