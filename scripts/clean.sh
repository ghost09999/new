#!/bin/bash

echo "=== НАЧИНАЮ ОЧИСТКУ СИСТЕМЫ ==="

# 1. Очистка кэша apt
echo "-> Очищаю кэш пакетов apt..."
sudo apt clean

# 2. Удаление ненужных зависимостей
echo "-> Удаляю ненужные зависимости..."
sudo apt autoremove -y

# 3. Очистка старых логов (старше 7 дней)
echo "-> Чищу старые логи..."
sudo journalctl --vacuum-time=7d

# 4. Очистка старых Snap-пакетов
echo "-> Удаляю старые версии Snap-пакетов..."
LANG=C snap list --all | awk '/disabled/{print $1, $3}' | while read snapname revision; do
    sudo snap remove "$snapname" --revision="$revision"
done

echo "=== ОЧИСТКА ЗАВЕРШЕНА ==="
echo "Свободное место на диске:"
df -h / | tail -n 1
