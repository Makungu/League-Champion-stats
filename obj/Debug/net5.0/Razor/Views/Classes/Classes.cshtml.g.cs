#pragma checksum "C:\Users\makun\Documents\01\WORK\leagueChampionStats\Views\Classes\Classes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1408ff6050bdf0d3958bffccb3e6370bcdb4b6e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classes_Classes), @"mvc.1.0.view", @"/Views/Classes/Classes.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\makun\Documents\01\WORK\leagueChampionStats\Views\_ViewImports.cshtml"
using leagueChampionStats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\makun\Documents\01\WORK\leagueChampionStats\Views\_ViewImports.cshtml"
using leagueChampionStats.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1408ff6050bdf0d3958bffccb3e6370bcdb4b6e1", @"/Views/Classes/Classes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23956eea67e77d3187aafaa97968ac2456b3151b", @"/Views/_ViewImports.cshtml")]
    public class Views_Classes_Classes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\makun\Documents\01\WORK\leagueChampionStats\Views\Classes\Classes.cshtml"
  
    ViewData["Title"] = "Playstyles";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class = ""container"">
    <div>
        <h1>Bruisers</h1>
        <P>
            This is the class for anyone who wants to be right in the frontline, taking loads of damage and dealing 
            just as much. Champions in this class are usually short range with high health but not a lot of base 
            resistances built into their kit. Their job is to be a bit tanky while also being able to run you down 
            with their decent damage.
        </P>

        <h1>Tanks</h1>
        <P>
            This class if for anyone that wants to sponge up the damage for the team, giving their team the chance to
            deal damage uninterrupted. Similar to bruisers they have above average health but not as much damage, with
            the trade off being that they have higher base armour and magic resistance stats.
        </P>

        <h1>Assassins</h1>
        <P>
            This class is for the people that enjoy making flashy plays and flexing their mechanics to outplay ");
            WriteLiteral(@"their
            opponents. These champions have a lot of burst damage and their role is to burst down priority targets 
            early in a fight and then use their mobility to weave in and out of the fight.
        </P>

        <h1>Mages</h1>
        <P>
            This class is for anyone with the ability to position well and land their skillshots. This class usually 
            sits in the back dealing massive aoe damage but have low health and low ability to recover it, this means 
            positioning is key so that you can hold on until late game where you will be killing everyone with just 
            a single basic ability
        </P>

        <h1>Enchanters</h1>
        <P>
            This class is for anyone that enjoys taking on the supportive role, buffing and healing their allies with
            different spells. Although this class of champions deal very little damage, they enable the strong memebers 
            of your team, making them near unkillable.
       ");
            WriteLiteral(@" </P>

        <h1>ADC</h1>
        <P>
            The ADC (Attack Damage Carry) class if for those that want to deal large amounts of damage with basic attacks.
            this class of champions have the highest dps but come with the trade off of having extremely low health and are 
            often the target focus of the enemy team. You'll need to rely on your team to help you out, as well as have 
            good positioning and ability to dodge key skillshots from enemies.
        </P>

    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591