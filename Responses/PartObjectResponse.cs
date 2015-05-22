using System;

namespace Octosharp.Responses
{
    public class PartObjectResponse
    {
        public string uid { get; set; }
        public string mpn { get; set; }
        public Brand brand { get; set; }
        public string __class__ { get; set; }
        public Offer[] offers { get; set; }
        public string octopart_url { get; set; }
        public Manufacturer manufacturer { get; set; }
    }
}

public class Brand
{
    public string homepage_url { get; set; }
    public string __class__ { get; set; }
    public string name { get; set; }
    public string uid { get; set; }
}

public class Manufacturer
{
    public string homepage_url { get; set; }
    public string __class__ { get; set; }
    public string name { get; set; }
    public string uid { get; set; }
}

public class Offer
{
    public string sku { get; set; }
    public object packaging { get; set; }
    public object on_order_eta { get; set; }
    public DateTime last_updated { get; set; }
    public object order_multiple { get; set; }
    public int in_stock_quantity { get; set; }
    public object eligible_region { get; set; }
    public int? moq { get; set; }
    public object on_order_quantity { get; set; }
    public string octopart_rfq_url { get; set; }
    public string __class__ { get; set; }
    public Seller seller { get; set; }
    public string product_url { get; set; }
    public object factory_order_multiple { get; set; }
    public int? factory_lead_days { get; set; }
    public Prices prices { get; set; }
    public bool is_authorized { get; set; }
    public bool is_realtime { get; set; }
}

public class Seller
{
    public string display_flag { get; set; }
    public bool has_ecommerce { get; set; }
    public string name { get; set; }
    public string __class__ { get; set; }
    public string homepage_url { get; set; }
    public string uid { get; set; }
}

public class Prices
{
    public object[][] USD { get; set; }
}