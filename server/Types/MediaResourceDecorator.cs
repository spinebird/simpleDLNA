using System;
using System.IO;
using NMaier.SimpleDlna.Server.Metadata;

namespace NMaier.SimpleDlna.Server
{
  internal class MediaResourceDecorator<T> : IMediaResource, IMetaInfo
    where T : IMediaResource, IMetaInfo
  {
    protected T resource;


    public MediaResourceDecorator(T resource)
    {
      this.resource = resource;
    }


    public virtual Stream Content
    {
      get
      {
        return resource.Content;
      }
    }
    public virtual IMediaCoverResource Cover
    {
      get
      {
        return resource.Cover;
      }
    }
    public string Id
    {
      get
      {
        return resource.Id;
      }
      set
      {
        resource.Id = value;
      }
    }
    public DateTime InfoDate
    {
      get
      {
        return resource.InfoDate;
      }
    }
    public long? InfoSize
    {
      get
      {
        return resource.InfoSize;
      }
    }
    public virtual DlnaMediaTypes MediaType
    {
      get
      {
        return resource.MediaType;
      }
    }
    public string Path
    {
      get
      {
        return resource.Path;
      }
    }
    public virtual string PN
    {
      get
      {
        return resource.PN;
      }
    }
    public virtual IHeaders Properties
    {
      get
      {
        return resource.Properties;
      }
    }
    public virtual string Title
    {
      get
      {
        return resource.Title;
      }
    }
    public DlnaMime Type
    {
      get
      {
        return resource.Type;
      }
    }


    virtual public int CompareTo(IMediaItem other)
    {
      return resource.CompareTo(other);
    }
  }
}
