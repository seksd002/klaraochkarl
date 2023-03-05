
//window.getTitle = () => {
//    return document.title;
//};
window.clipboardCopy = {
    copyText: function(text) {
        navigator.clipboard.writeText(text).then(function () {
            alert("Maillista kopierad till urklipp");
        })
        .catch(function (error) {
            alert(error);
        });
    }
};