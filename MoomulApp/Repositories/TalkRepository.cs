using System;
using System.Threading.Tasks;

namespace MoomulApp.Repositories;

public class TalkRepository
{
    public interface ITalkRepository
    {
        /// <summary>
        /// 최초로 계정을 생성하는 API로, 개발자만 사용합니다.
        /// </summary>
        /// <param name="name">계정 이름</param>
        Task CreateAccount(string name);
    }

    public class CosmosTalkRepository : ITalkRepository
    {
        public Task CreateAccount(string name)
        {
            throw new NotImplementedException();
        }
    }
}