function Add()
{
    var rqData =
    {
        //"Name": document.getElementById("ip_name").value,
        "MSV": document.getElementById("ip_MSV").value,
        "birthday": document.getElementById("ip_birthday").value,
        "MK": document.getElementById("ip_MK").value
    }
    Data.Name = $("#ip_name").val(); 
    var a = 0;
    $.ajax
    ({
        url: 'Student/jsonSaveStuden',
        type: 'POST',
        Data: JSON.stringify(rpData),
        contentType: "application/json; charset=utf-8",
        headers: {
            "Content-Type": "application/json",
        }
        }).done(function(rs)
        {
            alert(rs.mes);
        }                   
        )
}