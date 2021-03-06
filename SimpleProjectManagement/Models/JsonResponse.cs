using System.Collections.Generic;

namespace SimpleProjectManagement.Models
{
    public class JsonResponse
    {
        private readonly List<string> _errors = new List<string>();

        public bool Success { get; set; }
        public IEnumerable<string> Errors { get { return _errors; } }

        public void RegisterError(string error)
        {
            _errors.Fill(error);
        }
    }
}