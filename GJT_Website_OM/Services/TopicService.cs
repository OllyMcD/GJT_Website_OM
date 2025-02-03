using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

public class TopicService
{
    public event Action OnTopicChanged;

    private string? _selectedTopic;

    public string SelectedTopic
    {
        get => _selectedTopic;
        set
        {
            if (_selectedTopic != value)
            {
                _selectedTopic = value;
                NotifyTopicChanged();
            }
        }
    }

    private void NotifyTopicChanged() => OnTopicChanged?.Invoke();
}
