
//window.getTitle = () => {
//    return document.title;
//};
function hidehomebtn() {
    if (document.getElementById("heart")) {
        document.getElementById("homebtn").style.visibility = "hidden";

    }
    else {
        document.getElementById("homebtn").style.visibility = "visible";

    }
}