



$(document).ready(function () {



    /*------------------------------------
       Search
   --------------------------------------*/
    let ControllerName = $("#controllerName").val();

    let searchData = $("#searh-list");

    $("#searchInput").keyup(function () {

        let value = $(this).val();
        $("#searh-list li").slice(1).remove();

        axios.get(ControllerName+ '/Search?search=' + value)
            .then(function (response) {
                
                let datas = response.request.response;
                searchData.append(datas);
            })
            .catch(function (error) {
                // handle error
                console.log(error);
            });

    });











});