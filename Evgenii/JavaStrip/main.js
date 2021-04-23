function changeText()/*тут нужен пробел!*/{
    let centerText = document.getElementById('centerText');
    // Тут бы стоило поставить enter.
    if (centerText.textContent == 'Hello World')
    {
        centerText.textContent = 'JavaStrip';
    }
    // пишем return; стараемся не использовать else
    else
    {
        centerText.textContent = 'Hello World';
    }
    // Лишний Enter

}
/*
 В задании сказано найти кнопку по идентификатору(id, можно и любой другой)
 и навесить на него функцию изменяющую текст или сразу просто изменить на старте, как тебе хочется.
 Важно продемонстрировать навыки поиска элементов на странице по селектору.
*/
