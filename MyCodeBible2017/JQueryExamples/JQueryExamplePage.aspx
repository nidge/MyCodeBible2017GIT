<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JQueryExamplePage.aspx.cs" Inherits="JQueryExamples.JQueryExamplePage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>JQuery Examples</title>
    <script type="text/javascript" src="Scripts/jquery-1.4.1.js"></script>

        <style type="text/css">
            
  
  
            
            
  /*      #Ribbon\.Document\.All\.NewDocument\.Menu\.ContentTypes ul li:first-child 
        {
         display: none !important; 
        }
        */
        
        </style>
        

</head>
<body>
    <form id="form1" runat="server">
    <div>

        <ul class="level-1">
        <li class="item-i">I</li>
        <li class="item-ii">II
            <ul class="level-2">
                <li class="item-a">A</li>
                <li class="item-b">B
                    <ul class="level-3">
                        <li class="item-1">1</li>
                        <li class="item-2">2</li>
                        <li class="item-3">3</li>
                    </ul>   
                </li>
                <li class="item-c">C</li>
            </ul>
        </li>
        <li class="item-iii">III</li>
    </ul>

    <div id="Ribbon.Document.All.NewDocument.Menu.ContentTypes">
    
        <div class="ms-cui-menusection" unselectable="on">
            <ul class="ms-cui-menusection-items ms-cui-menusection-items32" unselectable="on">
                <li class="ms-cui-menusection-items" unselectable="on">
                    <a id="Ribbon.Document.All.NewDocument.Menu.ContentTypes.0-Menu32" title="Document" role="button" mscui:controltype="Button" class="ms-cui-ctl-menu ms-cui-ctl-menu32 " onclick="return false;" href="javascript:;" unselectable="on">
                        <span class="ms-cui-ctl-iconContainer" unselectable="on">
                            <span class=" ms-cui-img-32by32 ms-cui-img-cont-float" unselectable="on">
                                <img src="/_layouts/images/lg_icdotx.png" alt="Document" unselectable="on">
                            </span>
                        </span>
                        <span class="ms-cui-ctl-menulabel" unselectable="on">
                            <span class="ms-cui-ctl-mediumlabel ms-cui-btn-title" unselectable="on">Document</span>
                            <span style="display: block;" class="ms-cui-btn-menu-description" unselectable="on">Create a new document.</span>
                        </span>
                        <span class="ms-cui-ctl-menu32clear" unselectable="on">&nbsp;</span>
                        <span class="ms-cui-glass-ff" unselectable="on"></span>
                    </a>
                </li>
            </ul>
        </div>

        
    </div>

    <div id="Div1">
    
        <div class="ms-cui-menusection">
            <ul class="ms-cui-menusection-items ms-cui-menusection-items32">
                <li>
                    <img src="/_layouts/images/lg_icdotx1.png" alt="1">
                </li>
                <li>
                    <img src="/_layouts/images/lg_icdotx2.png" alt="2">
                </li>
                <li>
                    <img src="/_layouts/images/lg_icdotx3.png" alt="3">
                </li>
                <li>
                    <img src="/_layouts/images/lg_icdotx4.png" alt="4">
                </li>
            </ul>
        </div>

        
    </div>




    <script type="text/javascript">
        var $allListElements = $('li');
        $('li.item-ii').find($allListElements);
        var item1 = $('li.item-1')[0];
        $('li.item-ii').find(item1).css('background-color', 'red');
    </script>

    <p><span>Hello</span>, how are you?</p>
    <p>Me? I'm <span>good</span>.</p>
    <script>
        $("p").find("span").css('color', 'red');
        
    </script>

    
    </div>

    


    </form>
</body>
</html>







