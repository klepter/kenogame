# Создание системных диаграмм последовательностей

## Прецендент "Выбор ставки":

![Выбор ставки](images/lab3/ставка.png)

|| Выбрать ставку |
|---|---|
| Ссылки | Прецендент: Выбор ставки |
| Предусловия | Наличие у игрока денег для минимальной ставки |
| Постусловия | Ставка должна входить в установленные рамки |

|| Обнулить ставку |
|---|---|
| Ссылки | Прецендент: Выбор ставки |
| Предусловия | Игрок выбирает ставку больше своего банка |
| Постусловия | Ставка равна 0 |

|| Установить максимальную ставку |
|---|---|
| Ссылки | Прецендент: Выбор ставки |
| Предусловия | Игрок выбрал ставку больше максимальной |
| Постусловия | Ставка максимально возможная |

|| Зафиксировать ставку |
|---|---|
| Ссылки | Прецендент: Выбор ставки |
| Предусловия | Ставка валидна |
| Постусловия | Ставка зафиксирована для игры |

## Прецендент "Выбор чисел на поле":

![Выбор чисел на поле](images/lab3/споты.png)

|| Выбрать число на поле |
|---|---|
| Ссылки | Прецендент: Выбор чисел на поле |
| Предусловия | Число не выбрано |
| | Банка игрока достаточно |
| Постусловия | Число выбрано |

|| Убрать отметку с числа на поле |
|---|---|
| Ссылки | Прецендент: Выбор чисел на поле |
| Предусловия | Число выбрано |
| Постусловия | Число не выбрано |

|| Ограничить выбор чисел на поле |
|---|---|
| Ссылки | Прецендент: Выбор чисел на поле |
| Предусловия | Сумма ставки превышает банк игрока |
| Постусловия | Число не выбрано |

|| Установить отметку для числа на поле |
|---|---|
| Ссылки | Прецендент: Выбор чисел на поле |
| Предусловия | Число возможно выбрать|
| Постусловия | Число выбрано |

|| Зафиксировать набор чисел |
|---|---|
| Ссылки | Прецендент: Выбор чисел на поле |
| Предусловия | Количество выбранных чисел меньше 15 |
| | Банк игрока покрывает ставку |
| Постусловия | Зафиксирован набор чисел для игры |


## Прецендент "Выбор количества попыток":

![Выбор количества попыток](images/lab3/число%20попыток.png)

|| Указать количество попыток |
|---|---|
| Ссылки | Прецендент: Выбор количества попыток |
| Предусловия | Выбраны споты |
| | Банка игрока достаточно |
| Постусловия | Выбрано количество попыток |

|| Установить максимально возможное число попыток |
|---|---|
| Ссылки | Прецендент: Выбор количества попыток |
| Предусловия | Банка игрока недостаточно |
| Постусловия | Число попыток - максимальное |

|| Зафиксировать число попыток |
|---|---|
| Ссылки | Прецендент: Выбор количества попыток |
| Предусловия | Число попыток валидное |
| Постусловия | Число попыток зафиксировано для игры |

## Прецендент "Начало игры":

![Начало игры](images/lab3/начать%20игру.png)

|| Начать игру |
|---|---|
| Ссылки | Прецендент: Начало игры |
| Предусловия | Выбраны споты |
| | Выбрана ставка |
| | Выбрано количество попыток |
| Постусловия | Игра началась |

|| Вычесть с банка игрока сумму ставки |
|---|---|
| Ссылки | Прецендент: Начало игры |
| Предусловия | Игра началась |
| Постусловия | Банк игрока уменьшился на сумму ставки |

|| Сгенерировать победный набор |
|---|---|
| Ссылки | Прецендент: Начало игры |
| Предусловия | Игра началась |
| Постусловия | Победный набор зафиксирован для игры |

|| Отобразить победный набор |
|---|---|
| Ссылки | Прецендент: Начало игры |
| Предусловия | Победный набор зафиксирован для игры |
| Постусловия | Победный набор отмечен на поле |

|| Сравнить выбор игрока и победный набор |
|---|---|
| Ссылки | Прецендент: Начало игры |
| Предусловия | Победный набор зафиксирован для игры |
| Постусловия | Зафиксировать совпадения |

|| Вычислить выигрыш |
|---|---|
| Ссылки | Прецендент: Начало игры |
| Предусловия | Есть совпадения между выбором игрока и победным набором |
| Постусловия | Выигрыш зафиксирован для игры |

|| Начислить выигрыш на банк игрока |
|---|---|
| Ссылки | Прецендент: Начало игры |
| Предусловия | Выигрыш зафиксирован для игры |
| Постусловия | Банк игрока увеличился на выигрыш |

## Прецендент "Узнать выигрыш":

![Узнать выигрыш](images/lab3/узнать%20выигрыш.png)

|| Узнать выигрыш |
|---|---|
| Ссылки | Прецендент: Узнать выигрыш |
| Предусловия |  |
| Постусловия | Запрос на банк игрока |

|| Отобразить банк игрока |
|---|---|
| Ссылки | Прецендент: Узнать выигрыш |
| Предусловия | Запрос на банк игрока |
| Постусловия | Отобразится банк игрока |

## Прецендент "Очистить поле":

![Очистить поле](images/lab3/очистить%20поле.png)

|| Очистить поле |
|---|---|
| Ссылки | Прецендент: Очистить поле |
| Предусловия | Поле не очищено |
| Постусловия | Запрос на очистку поля |

|| Сбросить выбранный набор |
|---|---|
| Ссылки | Прецендент: Очистить поле |
| Предусловия | Запрос на очистку поля |
| Постусловия | Сброс выбранного набора для игры |

|| Убрать отметки на выбранных числах |
|---|---|
| Ссылки | Прецендент: Очистить поле |
| Предусловия | Выбранный набор для игры сброшен |
| Постусловия | Поле очищено |