#!/bin/bash

# Заходим в папку с проектом
cd ~/MyFirstApp

# Добавляем все измененные файлы
git add .

# Делаем коммит с текущей датой и временем (чтобы не писать сообщение каждый раз)
git commit -m "Auto-commit: $(date +'%Y-%m-%d %H:%M')"

# Отправляем на GitHub
git push origin main

echo "Код успешно залит на GitHub!"
