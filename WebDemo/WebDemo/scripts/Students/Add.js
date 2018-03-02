function Add()
{
    var rqData =
    {
        "Id": 10,
        //"Name": document.getElementById("ip_name").value,
        "codeSV": $("#ip_MSV").val(),
        //"birthday": new (document.getElementById("ip_birthday").value),
        "codeCN": document.getElementById("ip_MK").value
    }
    rqData.birthdaystr = $("#ip_birthday").val();
    rqData.fullName = $("#ip_name").val();

    if (rqData.fullName.trim() == "" || rqData.fullName.length == 0) {
        alert("Name")
        //showSystemNotify(invalidFromFullNameEmptyMsg, 'warning');
        $("#ip_name").focus();
        return false;

    }

    if (rqData.codeSV.trim() == "" || rqData.codeSV.length == 0) {
        alert("MSV")
        //showSystemNotify(invalidFromFullNameEmptyMsg, 'warning');
        $("#ip_MSV").focus();
        return false;
    }
     
    if (rqData.birthdaystr.length == 0 || $('#ip_birthday input[type=text]').val() == '') {
        alert("Ngày Sinh")
        //showSystemNotify(invalidFromFullNameEmptyMsg, 'warning');
        $("#ip_birthday").focus();
        return false;
    }
    var a = 0;
    $.ajax
    ({
        url: "/Students/jsonSaveStudent",
        type: "POST",
        method: "POST",
        data: JSON.stringify(rqData),
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        headers: {
            "Content-Type": "application/json",
        }
        }).done(function(rs)
        {
            alert(rs.Message);
        }                   
        )
}
