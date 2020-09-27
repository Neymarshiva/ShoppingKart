using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelperClass.Componet
{
    public class ConfirmBase : ComponentBase
    {
        protected bool ShowConfirmation { get; set; }

        [Parameter]
        public string ConfirmationTitle { get; set; } = "Confirm Delete";

        [Parameter]
        public string ConfirmationMessage { get; set; } = "Are you sure you want to delete";


        [Parameter]
        public EventCallback<bool> ConfirmationChanged { get; set; }

        public void Show()
        {
            ShowConfirmation = true;
            StateHasChanged();
        }

        public async Task OnConfirmationChanged(bool value)
        {
            ShowConfirmation = false;
            await ConfirmationChanged.InvokeAsync(value);
        }

    }
}
