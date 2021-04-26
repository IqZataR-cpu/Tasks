window.onclick = ReplaceText;


/* 
Для справки:
1. Все гуд, но в лучше на window ничего не навешивать.
2. Если ты сделаешь локальную переменную
let mainContainer = document.getElementById('main');
То сохранишь ссылку на элемент с этим id.
и в функции сможешь сделать просто mainContainer.innerHtml = 'JavaStrip';
тем самым ты не будешь заново искать элемент по id при каждом клике.

Полный код был бы такой:
let mainContainer = document.getElementById('main');

mainContainer.onclick = ReplaceText;

function ReplaceText(){
    mainContainer.innerHTML = 'JavaStrip';
}

*/
function ReplaceText(){
    document.getElementById('main').innerHTML = 'JavaStrip';
}


