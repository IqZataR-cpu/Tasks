function changeText()/*тут нужен пробел!*/{
    let centerText = document.getElementById('centerText');

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



 ???Что от меня требуется? Я это и сделал???
*/
