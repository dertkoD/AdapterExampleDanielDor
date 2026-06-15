using TMPro;

public class UILogger
{
    private TMP_Text textBox;

    public UILogger(TMP_Text textBox)
    {
        this.textBox = textBox;
    }

    public void WriteToUI(string text)
    {
        textBox.text += text + "\n";
    }
}