using System.Text.Json;
using System.Xml;

namespace cs_json_indent
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            textBoxOutput.Text = IndentJson(textBoxInput.Text);
        }

        /// <summary>
        /// JSON文字列を見やすくインデントします。
        /// </summary>
        /// <param name="intput">整形前のJSON文字列</param>
        /// <returns>整形後のJSON文字列</returns>
        private static string IndentJson(string intputJson)
        {
            try
            {
                // JSON文字列をオブジェクトに変換
                var obj = JsonSerializer.Deserialize<object>(intputJson);

                // インデントのオプションを設定
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                // オブジェクトをインデント付きのJSON文字列に変換
                string indentedJson = JsonSerializer.Serialize(obj, options);

                // JSON文字列を返却
                return indentedJson;
            }
            catch (Exception ex)
            {
                // エラー表示
                return "error!!" + Environment.NewLine + Environment.NewLine + ex.Message;
            }
        }
    }
}
