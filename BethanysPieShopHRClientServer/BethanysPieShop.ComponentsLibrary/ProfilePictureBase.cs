using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BethanysPieShopHRM.ComponentsLibrary
{
    public class ProfilePictureBase : ComponentBase
    {

        [Parameter] //this attribute is mandatory if this property will be set by another component. The name ChildContent is also mandatory in this case
        public RenderFragment ChildContent { get; set; }
    }
}
