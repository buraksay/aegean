package com.buraksay.aegean.data;

public class IAmAliveResponse {
    private String tid;
    private String status = "Hello";

    public IAmAliveResponse() {
        super();
    }

    public IAmAliveResponse(IAmAliveRequest request) {
        this.tid = request.getTid();
    }

    public String getTid() {
        return tid;
    }

    public void setTid(String tid) {
        this.tid = tid;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    @Override
    public String toString() {
        return "IAmAliveResponse [tid=" + tid + ", status=" + status + "]";
    }

}
