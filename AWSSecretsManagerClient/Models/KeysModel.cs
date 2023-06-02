using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSecretsManagerClient.Models
{
    public class KeysModel
    {
        public string MySql { get; set; }
        public string S3Bucket { get; set; }
        public string ApiPersonajes { get; set; }
        public string Champions { get; set; }
    }

}
