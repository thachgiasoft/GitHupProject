<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCartson.aspx.cs" Inherits="WebApplication1.Admin.Cartonn.AddCartson" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script src="../../esayUI/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script src="../../esayUI/themes/MyAjaxForm.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("#imgbtn").click(function () {

                if ($("#filesq").val()) {
                    $("#form1").ajaxSubmit({
                        url: "/Admin/Cartonn/UpCartsonImageashx.ashx",
                        error: function (error) { alert(error); },
                        type: "post",
                        dataType: "text",
                        success: function (data) {
                            $("#hiddenfile").val(data);
                            $("#img").attr("src", data);
                        }

                    });
                } else {
                    alert("没有选择文件");
                }

            })
        })
    </script>
</head>
<body>
    <%--要异步上传图片--%>
    <form id="form1" runat="server" enctype="multipart/form-data">
    <div>
        <input type="hidden" name="id" value="<%=CartSon.Id %>" />
        <input type="hidden" name="data" value="<%=CartSon.AddDateTime %>" />

        <table border="1" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    漫画集名称
                </td>
                <td>
                    <input type="text" name="CartName" value="<%:CartSon.CartoonSonName %>" />
                </td>
            </tr>
            <tr>
                <td>
                    漫画集数
                </td>
                <td>
                    <input type="text" name="CartNum" value="<%:CartSon.CartNum%>" />
                </td>
            </tr>
            <tr>
                <td>
                    漫画类型
                </td>
                <td>
                    <select name="CategoriesId">
                        <%
                          for (int i = 0; i < list.Count; i++)
                          {
                              if (CartSon.CartId != null && i == CartSon.CartId - 1)
                              {%>
                               <option value="<%:list[i].Id %>" selected="selected">
                                    <%:list[i].CartoonName%>
                                  </option>
                              <%}
                              else
                              { %>

                                  <option value="<%:list[i].Id %>">
                                    <%:list[i].CartoonName %>
                                  </option>
                              <%}
                          
                          
                          
                          } %>
                    </select>
                </td>
            </tr>
            <tr>
                <td>
                    漫画封面
                </td>
                <td>
                    <input type="hidden" name="hiddenfile" id="hiddenfile" value="<%:CartSon.CartoonSonIamge %>" />
                    <input type="file" name="CartImage" id="filesq" />
                    <input type="button" name="name" value="上传" id="imgbtn" />
                    <img src="<%:CartSon.CartoonSonIamge %>" alt="Alternate Text" id="img" />
                </td>
            </tr>
        </table>
        <input type="submit" name="btn" value="提交" />
    </div>
    </form>
    
</body>
</html>
