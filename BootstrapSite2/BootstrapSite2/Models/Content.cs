using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapSite2.Models
{
    public class Content
    {
        public List<Chapter> Chapters { get; set; }
    }

    public class Chapter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MainTopic> MainTopics { get; set; }
    }

    public class MainTopic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ChapterId { get; set; }
        public string SubDetail { get; set; }
        public MainTopicDescription Description { get; set; }
        public List<Example> Examples { get; set; }
    }

    public class MainTopicDescription
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string MainTopicId { get; set; }
        public List<SubTopic> SubTopics { get; set; }
    }

    public class SubTopic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MainTopicId { get; set; }
        public string SubDetail { get; set; }
        public SubTopicDescription Description { get; set; }
        public List<Example> Examples { get; set; }
    }

    public class SubTopicDescription
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string SubTopicId { get; set; }
    }

    public class Example
    {
        public int Id { get; set; }
        public TopicType TopicType { get; set; }
        public int TopicId { get; set; }
        public string Description { get; set; }
    }

    public enum TopicType
    {
        Main = 0,
        Sub = 1
    }

}