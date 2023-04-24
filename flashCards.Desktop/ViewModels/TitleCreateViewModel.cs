using flashCards.Desktop.Common;
using flashCards.Desktop.Models;
using System;

namespace flashCards.Desktop.ViewModels
{
    public class TitleCreateViewModel
    {
        public string WordsTitle { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;

        public static implicit operator Title(TitleCreateViewModel titleCreateViewModel)
        {
            return new Title()
            {
                UserId = IdentitySingelton.GetInstance().UserId,
                WordsTitle = titleCreateViewModel.WordsTitle,
                Description = titleCreateViewModel.Description,
            };
        }
    }
}
