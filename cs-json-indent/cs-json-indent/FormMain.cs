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
        /// �e�L�X�g�{�b�N�X���ύX���ꂽ�Ƃ��ɏ������܂��B
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            textBoxOutput.Text = IndentJson(textBoxInput.Text);
        }

        /// <summary>
        /// JSON����������₷���C���f���g���܂��B
        /// </summary>
        /// <param name="intput">���`�O��JSON������</param>
        /// <returns>���`���JSON������</returns>
        private static string IndentJson(string inputJson)
        {
            try
            {
                // ���̓`�F�b�N
                if (inputJson.Length == 0) { return string.Empty; }

                // JSON��������I�u�W�F�N�g�ɕϊ�
                var obj = JsonSerializer.Deserialize<object>(inputJson);

                // �C���f���g�̃I�v�V������ݒ�
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                // �I�u�W�F�N�g���C���f���g�t����JSON������ɕϊ�
                string indentedJson = JsonSerializer.Serialize(obj, options);

                // JSON�������ԋp
                return indentedJson;
            }
            catch (Exception ex)
            {
                // �G���[�\��
                return "error!!" + Environment.NewLine + Environment.NewLine + ex.Message;
            }
        }

        private void labelDescription_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var f in files)
            {
                string fileName = f;
                textBoxOutput.Text += fileName + Environment.NewLine;
            }
        }
    }
}
