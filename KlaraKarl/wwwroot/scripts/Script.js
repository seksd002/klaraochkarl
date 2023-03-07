
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
function hearts()
{
    const hearts = [];

    // skapa hjärtan och lägg till dem i arrayen
    for (let i = 0; i < 50; i++) {
        const heart = document.createElementNS("http://www.w3.org/2000/svg", "svg");
        heart.classList.add("heart");
        heart.innerHTML = '<path d="M15,0 C6.716,0 0,6.716 0,15 C0,23.284 6.716,30 15,30 C23.284,30 30,23.284 30,15 C30,6.716 23.284,0 15,0 Z" />';
        document.querySelector(".hearts-container").appendChild(heart);
        hearts.push(heart);
    }

    // uppdatera positionen på hjärtanen slumpmässigt varje sekund
    setInterval(() => {
        for (const heart of hearts) {
            const x = Math.random() * window.innerWidth;
            const y = Math.random() * window.innerHeight;
            heart.style.transform = `translate(${x}px, ${y}px)`;
        }
    }, 1000);
}
