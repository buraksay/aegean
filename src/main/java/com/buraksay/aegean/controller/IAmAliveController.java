package com.buraksay.aegean.controller;

import javax.ws.rs.Consumes;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;

import org.codehaus.jackson.map.ObjectMapper;
import org.codehaus.jackson.map.SerializationConfig;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.stereotype.Component;

import com.buraksay.aegean.data.IAmAliveRequest;
import com.buraksay.aegean.data.IAmAliveResponse;

@Path("/iamalive")
@Produces({ MediaType.APPLICATION_JSON })
@Consumes({ MediaType.APPLICATION_JSON })
@Component
public class IAmAliveController {

    private static final Logger LOGGER = LoggerFactory.getLogger(IAmAliveController.class);

    @POST
    public Response iamalivePost(final IAmAliveRequest request) throws Exception {

        if (LOGGER.isDebugEnabled()) {
            ObjectMapper mapper = new ObjectMapper();
            try {
                String jsonString = mapper.writeValueAsString(request);
                LOGGER.debug("Match Request: " + jsonString);
            } catch (Exception e) {
                LOGGER.error(e.getMessage());
            }
        }
        ObjectMapper mapper = new ObjectMapper();
        mapper.enable(SerializationConfig.Feature.INDENT_OUTPUT);

        LOGGER.debug("Received IAMALIVE request: " + mapper.writeValueAsString(request));
        IAmAliveResponse response = new IAmAliveResponse(request);
        LOGGER.debug("Sending IAMALIVE response: " + mapper.writeValueAsString(response));

        return Response.ok(response).build();
    }

}
