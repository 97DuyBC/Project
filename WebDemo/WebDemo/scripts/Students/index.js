﻿$(document).ready(function () {
    getStudent();
    function getStudent() {
        var reqData = {}
        //var a=0;
        $.ajax
        ({
            url: '/Students/jsonListStudent',
            method: "POST",
            type: 'POST',
            data: JSON.stringify(reqData),
            dataType: 'json',
            contentType: "application/json; charset=utf-8",
            headers: {
                "Content-Type": "application/json",
            }
            }).done(function(rs)
            {
                //var b = 1;
                $('#listStudents').tmpl(rs.Data).appendTo('#content');
            })        
    }
})

//Return date
function GetDateTime(jsonDate) {
    //var c = 1;
    var value = new Date(parseInt(jsonDate.substr(6)));
    return value.getMonth() + 1 + "/" + value.getDate() + "/" + value.getFullYear();
}