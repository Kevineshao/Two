using Qiniu.Http;
using Qiniu.Storage;
using Qiniu.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two.QiNiu
{
    public class UpLoading : Volo.Abp.Application.Services.ApplicationService
    {

        public bool Updt(string upLoadFile)
        {

            bool bresult = false;
            string fileName = System.IO.Path.GetFileNameWithoutExtension(upLoadFile);
            Mac mac = new Mac("T1BPwVrGFlBfnXJMTrISFw4qTfdjDJUAj-1eFtxX", "Nsty-r3TUCpDKVOeWossfU3ASdVagm4ddDvXCQS_");
            string key = fileName;//文件名称
            string filePath = upLoadFile;//上传路径

            PutPolicy putPolicy = new PutPolicy();
            putPolicy.Scope = "project123:" + key;
            putPolicy.SetExpires(3600);
            putPolicy.DeleteAfterDays = 1;
            string token = Auth.CreateUploadToken(mac, putPolicy.ToJsonString());
            Config config = new Config();
            config.Zone = Zone.ZONE_CN_East;
            config.UseHttps = true;
            config.UseCdnDomains = true;
            config.ChunkSize = ChunkUnit.U512K;
            FormUploader target = new FormUploader(config);
            HttpResult result = target.UploadFile(filePath, key, token, null);

            string back = result.Code.ToString();
            //LogHelper.WriteLog_LocalTxt("result:" + result);
            if (result.Code.ToString() == "200")
                bresult = true;

            return bresult;
        }
    }
       
}

