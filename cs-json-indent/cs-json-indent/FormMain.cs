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

        /// <summary>
        /// テキストボックスが変更されたときに発生します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            textBoxOutput.Text = IndentJson(textBoxInput.Text);
        }

        /// <summary>
        /// ドラッグしたときに発生します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Control_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) ?? false)
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// ドラッグアンドドロップしたときに発生します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Control_DragDrop(object sender, DragEventArgs e)
        {
            var files = ((string[]?)e.Data?.GetData(DataFormats.FileDrop, false)) ?? new string[0];
            foreach (var f in files)
            {
                string fileName = f;
                textBoxOutput.Text += fileName + Environment.NewLine;
            }
        }

        /// <summary>
        /// JSON文字列を見やすくインデントします。
        /// </summary>
        /// <param name="intput">整形前のJSON文字列</param>
        /// <returns>整形後のJSON文字列</returns>
        private static string IndentJson(string inputJson)
        {
            try
            {
                // 入力チェック
                if (inputJson.Length == 0) { return string.Empty; }

                // JSON文字列をオブジェクトに変換
                var obj = JsonSerializer.Deserialize<object>(inputJson);

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
