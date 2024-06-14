﻿using System.Windows.Forms;

public static class MessageHelper
{
    public static void Show(string message, string header = "")
    {
        MessageBox.Show(message, header);
    }

    public static void ShowWarning(string message)
    {
        MessageBox.Show(message, "Внимание!");
    }

    public static void ShowError(string message)
    {
        MessageBox.Show(message, "Ошибка!");
    }

    public static void ShowException(string message)
    {
        MessageBox.Show(message, "Вызвано исключение!");
    }
}