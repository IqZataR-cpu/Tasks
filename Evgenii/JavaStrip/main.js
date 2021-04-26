let mbutton = document.getElementById('mainButton');

mbutton.onclick = replaceText;

function replaceText(event) {
    if (event.target.innerText == 'Hello World') {
        event.target.innerText = 'JavaStrip';

        return;
    }

    event.target.innerText = 'Hello World';
}











/*
let btn = document.querySelector('.mainButton');
let centerText = document.getElementById('centerText');

btn.onclick = changeText;

function changeText(event) {
    if (centerText.textContent == 'Hello World')
    {
        centerText.textContent = 'JavaStrip';
        return;
    }
    
    centerText.textContent = 'Hello World';
}


/*
 В задании сказано найти кнопку по идентификатору(id, можно и любой другой)
 и навесить на него функцию изменяющую текст или сразу просто изменить на старте, как тебе хочется.
 Важно продемонстрировать навыки поиска элементов на странице по селектору.


 Представь, что у тебя нет файла index.html, ты не можешь его открыть.
 Тебе нужно навесить обработчик события onclick на кнопку с классом mainButton.
 Твои действия?
*/
