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
        /// JSON����������₷���C���f���g���܂��B
        /// </summary>
        /// <param name="intput">���`�O��JSON������</param>
        /// <returns>���`���JSON������</returns>
        private static string IndentJson(string intputJson)
        {
            try
            {
                // JSON��������I�u�W�F�N�g�ɕϊ�
                var obj = JsonSerializer.Deserialize<object>(intputJson);

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
    }
}
