<script type="text/javascript">
function disable_enable(_this)
{
  if (_this == 'login')
    {
    document.test.login.disabled=true;
   document.test.logout.disabled=false; }
    else
    {
        document.test.login.disabled=false;
        document.test.logout.disabled=true;
    }
} 
</script>
<form name="test" >
<input type="button" id="login" value="login" name="b1" onclick="disable_enable('login');" >
<input type="button" id="logout" value="logout" name="b2" onclick="disable_enable('logout');">
</form>
